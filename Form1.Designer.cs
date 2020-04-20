namespace IniDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.KillRateUpDown = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GameWinRateUpDown = new System.Windows.Forms.DomainUpDown();
            this.DBConnectGroupBox = new System.Windows.Forms.GroupBox();
            this.txtDBConnet = new System.Windows.Forms.TextBox();
            this.CommServerGroupBox = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.DBConnectGroupBox.SuspendLayout();
            this.CommServerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnOK);
            this.groupBox4.Controls.Add(this.KillRateUpDown);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.GameWinRateUpDown);
            this.groupBox4.Location = new System.Drawing.Point(8, 245);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(521, 258);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GameWinRate";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 195);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 19);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Automatic";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 158);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 19);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Manual";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "%";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(309, 186);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // KillRateUpDown
            // 
            this.KillRateUpDown.Location = new System.Drawing.Point(21, 106);
            this.KillRateUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KillRateUpDown.Name = "KillRateUpDown";
            this.KillRateUpDown.Size = new System.Drawing.Size(181, 22);
            this.KillRateUpDown.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kill Rate";
            // 
            // GameWinRateUpDown
            // 
            this.GameWinRateUpDown.Location = new System.Drawing.Point(21, 30);
            this.GameWinRateUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameWinRateUpDown.Name = "GameWinRateUpDown";
            this.GameWinRateUpDown.Size = new System.Drawing.Size(181, 22);
            this.GameWinRateUpDown.TabIndex = 1;
            // 
            // DBConnectGroupBox
            // 
            this.DBConnectGroupBox.Controls.Add(this.txtDBConnet);
            this.DBConnectGroupBox.Location = new System.Drawing.Point(8, 164);
            this.DBConnectGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBConnectGroupBox.Name = "DBConnectGroupBox";
            this.DBConnectGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBConnectGroupBox.Size = new System.Drawing.Size(521, 74);
            this.DBConnectGroupBox.TabIndex = 5;
            this.DBConnectGroupBox.TabStop = false;
            this.DBConnectGroupBox.Text = "DB Connect String";
            // 
            // txtDBConnet
            // 
            this.txtDBConnet.Location = new System.Drawing.Point(11, 25);
            this.txtDBConnet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDBConnet.Name = "txtDBConnet";
            this.txtDBConnet.Size = new System.Drawing.Size(416, 22);
            this.txtDBConnet.TabIndex = 0;
            // 
            // CommServerGroupBox
            // 
            this.CommServerGroupBox.Controls.Add(this.txtPassword);
            this.CommServerGroupBox.Controls.Add(this.txtAppName);
            this.CommServerGroupBox.Controls.Add(this.txtPort);
            this.CommServerGroupBox.Controls.Add(this.txtIP);
            this.CommServerGroupBox.Controls.Add(this.label7);
            this.CommServerGroupBox.Controls.Add(this.label6);
            this.CommServerGroupBox.Controls.Add(this.label5);
            this.CommServerGroupBox.Controls.Add(this.label4);
            this.CommServerGroupBox.Location = new System.Drawing.Point(8, 12);
            this.CommServerGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CommServerGroupBox.Name = "CommServerGroupBox";
            this.CommServerGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CommServerGroupBox.Size = new System.Drawing.Size(521, 144);
            this.CommServerGroupBox.TabIndex = 2;
            this.CommServerGroupBox.TabStop = false;
            this.CommServerGroupBox.Text = "Comm Server Setting";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(356, 106);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(136, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(95, 99);
            this.txtAppName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(123, 22);
            this.txtAppName.TabIndex = 6;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(265, 39);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(121, 22);
            this.txtPort.TabIndex = 5;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(35, 39);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(167, 22);
            this.txtIP.TabIndex = 4;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "App Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 518);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.DBConnectGroupBox);
            this.Controls.Add(this.CommServerGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.DBConnectGroupBox.ResumeLayout(false);
            this.DBConnectGroupBox.PerformLayout();
            this.CommServerGroupBox.ResumeLayout(false);
            this.CommServerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown KillRateUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown GameWinRateUpDown;
        private System.Windows.Forms.GroupBox DBConnectGroupBox;
        private System.Windows.Forms.TextBox txtDBConnet;
        private System.Windows.Forms.GroupBox CommServerGroupBox;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
    }
}

