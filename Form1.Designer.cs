
namespace Cheker_accounts
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Socks5 = new System.Windows.Forms.RadioButton();
            this.Button_Socks4 = new System.Windows.Forms.RadioButton();
            this.Button_Https = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.ListView_Results = new System.Windows.Forms.ListView();
            this.column_Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Accounts = new System.Windows.Forms.Label();
            this.label_Proxy = new System.Windows.Forms.Label();
            this.label_Checked = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Errors = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Valid = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_NoValid = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить аккаунты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 173);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 101);
            this.button2.TabIndex = 1;
            this.button2.Text = "Загрузить прокси";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Socks5);
            this.groupBox1.Controls.Add(this.Button_Socks4);
            this.groupBox1.Controls.Add(this.Button_Https);
            this.groupBox1.Location = new System.Drawing.Point(16, 301);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy Type";
            // 
            // Button_Socks5
            // 
            this.Button_Socks5.AutoSize = true;
            this.Button_Socks5.Location = new System.Drawing.Point(8, 85);
            this.Button_Socks5.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Socks5.Name = "Button_Socks5";
            this.Button_Socks5.Size = new System.Drawing.Size(77, 21);
            this.Button_Socks5.TabIndex = 5;
            this.Button_Socks5.TabStop = true;
            this.Button_Socks5.Text = "SOCKS 5";
            this.Button_Socks5.UseVisualStyleBackColor = true;
            // 
            // Button_Socks4
            // 
            this.Button_Socks4.AutoSize = true;
            this.Button_Socks4.Location = new System.Drawing.Point(8, 55);
            this.Button_Socks4.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Socks4.Name = "Button_Socks4";
            this.Button_Socks4.Size = new System.Drawing.Size(77, 21);
            this.Button_Socks4.TabIndex = 4;
            this.Button_Socks4.TabStop = true;
            this.Button_Socks4.Text = "SOCKS 4";
            this.Button_Socks4.UseVisualStyleBackColor = true;
            // 
            // Button_Https
            // 
            this.Button_Https.AutoSize = true;
            this.Button_Https.Checked = true;
            this.Button_Https.Location = new System.Drawing.Point(8, 25);
            this.Button_Https.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Https.Name = "Button_Https";
            this.Button_Https.Size = new System.Drawing.Size(67, 21);
            this.Button_Https.TabIndex = 3;
            this.Button_Https.TabStop = true;
            this.Button_Https.Text = "HTTPS";
            this.Button_Https.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point(16, 462);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 101);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Потоки(Threads)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 55);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(251, 25);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 599);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 101);
            this.button3.TabIndex = 4;
            this.button3.Text = "Старт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListView_Results
            // 
            this.ListView_Results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Mail,
            this.column_Password});
            this.ListView_Results.HideSelection = false;
            this.ListView_Results.Location = new System.Drawing.Point(360, 37);
            this.ListView_Results.Margin = new System.Windows.Forms.Padding(4);
            this.ListView_Results.Name = "ListView_Results";
            this.ListView_Results.Size = new System.Drawing.Size(989, 505);
            this.ListView_Results.TabIndex = 5;
            this.ListView_Results.UseCompatibleStateImageBehavior = false;
            this.ListView_Results.View = System.Windows.Forms.View.Details;
            // 
            // column_Mail
            // 
            this.column_Mail.Text = "Email";
            this.column_Mail.Width = 490;
            // 
            // column_Password
            // 
            this.column_Password.Text = "Password";
            this.column_Password.Width = 643;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(356, 599);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кол-во аккаунтов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(356, 683);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во Прокси:";
            // 
            // label_Accounts
            // 
            this.label_Accounts.AutoSize = true;
            this.label_Accounts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Accounts.Location = new System.Drawing.Point(496, 599);
            this.label_Accounts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Accounts.Name = "label_Accounts";
            this.label_Accounts.Size = new System.Drawing.Size(15, 17);
            this.label_Accounts.TabIndex = 8;
            this.label_Accounts.Text = "0";
            // 
            // label_Proxy
            // 
            this.label_Proxy.AutoSize = true;
            this.label_Proxy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Proxy.Location = new System.Drawing.Point(496, 683);
            this.label_Proxy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Proxy.Name = "label_Proxy";
            this.label_Proxy.Size = new System.Drawing.Size(15, 17);
            this.label_Proxy.TabIndex = 9;
            this.label_Proxy.Text = "0";
            // 
            // label_Checked
            // 
            this.label_Checked.AutoSize = true;
            this.label_Checked.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Checked.Location = new System.Drawing.Point(704, 599);
            this.label_Checked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Checked.Name = "label_Checked";
            this.label_Checked.Size = new System.Drawing.Size(15, 17);
            this.label_Checked.TabIndex = 11;
            this.label_Checked.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(564, 599);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Проверено:";
            // 
            // label_Errors
            // 
            this.label_Errors.AutoSize = true;
            this.label_Errors.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Errors.Location = new System.Drawing.Point(704, 683);
            this.label_Errors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Errors.Name = "label_Errors";
            this.label_Errors.Size = new System.Drawing.Size(15, 17);
            this.label_Errors.TabIndex = 13;
            this.label_Errors.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(564, 683);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ошибки:";
            // 
            // label_Valid
            // 
            this.label_Valid.AutoSize = true;
            this.label_Valid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Valid.Location = new System.Drawing.Point(1070, 599);
            this.label_Valid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Valid.Name = "label_Valid";
            this.label_Valid.Size = new System.Drawing.Size(15, 17);
            this.label_Valid.TabIndex = 15;
            this.label_Valid.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(930, 599);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Валидные:";
            // 
            // label_NoValid
            // 
            this.label_NoValid.AutoSize = true;
            this.label_NoValid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NoValid.Location = new System.Drawing.Point(1070, 683);
            this.label_NoValid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NoValid.Name = "label_NoValid";
            this.label_NoValid.Size = new System.Drawing.Size(15, 17);
            this.label_NoValid.TabIndex = 17;
            this.label_NoValid.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(930, 683);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Не валидные:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 727);
            this.Controls.Add(this.label_NoValid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_Valid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_Errors);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_Checked);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_Proxy);
            this.Controls.Add(this.label_Accounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListView_Results);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checker Accounts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Button_Socks5;
        private System.Windows.Forms.RadioButton Button_Socks4;
        private System.Windows.Forms.RadioButton Button_Https;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView ListView_Results;
        private System.Windows.Forms.ColumnHeader column_Mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Accounts;
        private System.Windows.Forms.Label label_Proxy;
        private System.Windows.Forms.Label label_Checked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Errors;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Valid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_NoValid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader column_Password;
    }
}

