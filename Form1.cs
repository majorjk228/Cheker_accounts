using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Leaf.xNet;
using System.Threading;

namespace Cheker_accounts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\\Results\\");
        }

        public int good_count = 0;
        public int bad_count = 0;

        public int checked_count = 0;

        public int proxy_errors = 0;

        public string[] accounts;
        public string[] proxies;

        string currentTime = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");

        private void writeToFile(string email)
        {
            string fileName = Environment.CurrentDirectory + @"\\Results\\[Good] " + currentTime + ".txt";
            File.AppendAllText(fileName, email + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Обзор Аккаунтов";
            openFileDialog.Filter = "Accounts | *.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                accounts = File.ReadAllLines(openFileDialog.FileName.ToString());
                label_Accounts.Text = accounts.Length.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Обзор Прокси";
            openFileDialog.Filter = "Proxy | *.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                proxies = File.ReadAllLines(openFileDialog.FileName.ToString());
                label_Proxy.Text = accounts.Length.ToString();
            }
        }

        public string randomProxy()
        {
            Random random = new Random();
            int index = random.Next(proxies.Length);

            return proxies[index];
        }

        private void checker(string email)
        {
            string url = $"https://spclient.wg.spotify.com/signup/public/v1/account?validate=1&email={email}";

            Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest();
            httpRequest.UserAgent = Http.ChromeUserAgent();

            while (true)
            {
                if (Button_Https.Checked)

                    httpRequest.Proxy = HttpProxyClient.Parse(randomProxy());

                else if (Button_Socks4.Checked)
                    httpRequest.Proxy = Socks4ProxyClient.Parse(randomProxy());


                else if (Button_Socks5.Checked)
                    httpRequest.Proxy = Socks5ProxyClient.Parse(randomProxy()); 

                try
                {
                    string response = httpRequest.Get(url).ToString();

                    if (response.Contains("{\"status\":20"))
                    {
                        good_count += 1;
                        checked_count += 1;

                        label_Valid.Text = good_count.ToString();
                        label_Checked.Text = checked_count.ToString();

                        string[] row = { email };
                        var listItem = new ListViewItem(row);
                        ListView_Results.Items.Add(listItem);

                        writeToFile(email);

                        break;
                    }
                    else
                    {
                        bad_count += 1;
                        checked_count += 1;

                        label_NoValid.Text = bad_count.ToString();
                        label_Checked.Text = checked_count.ToString();
                    }
                }
                catch (Leaf.xNet.HttpException ex)
                {
                    if (ex.Status.Equals(HttpExceptionStatus.ConnectFailure))
                    {
                        proxy_errors += 1;
                        label_Errors.Text = proxy_errors.ToString();
                    }
                }
            }
        }

        public void seperateThread()
        {

            Parallel.ForEach(

            accounts,
            new ParallelOptions
            {
                MaxDegreeOfParallelism = Convert.ToInt32(numericUpDown1.Value) //NumericUpDown.Value
            },
            combo =>
            {
                checker(combo);
            }
            ); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Thread thread = new Thread(seperateThread); //seperateThread
            thread.Start();
            thread.IsBackground = true;
        }
    }
}
