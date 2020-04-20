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
            this.btnOK = new System.Windows.Forms.Button();
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
            this.groupBox4.Location = new System.Drawing.Point(6, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(391, 206);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GameWinRate";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 156);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Automatic";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Manual";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "%";
            // 
            // KillRateUpDown
            // 
            this.KillRateUpDown.Location = new System.Drawing.Point(16, 85);
            this.KillRateUpDown.Name = "KillRateUpDown";
            this.KillRateUpDown.Size = new System.Drawing.Size(136, 21);
            this.KillRateUpDown.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kill Rate";
            // 
            // GameWinRateUpDown
            // 
            this.GameWinRateUpDown.Location = new System.Drawing.Point(16, 24);
            this.GameWinRateUpDown.Name = "GameWinRateUpDown";
            this.GameWinRateUpDown.Size = new System.Drawing.Size(136, 21);
            this.GameWinRateUpDown.TabIndex = 1;
            // 
            // DBConnectGroupBox
            // 
            this.DBConnectGroupBox.Controls.Add(this.txtDBConnet);
            this.DBConnectGroupBox.Location = new System.Drawing.Point(6, 131);
            this.DBConnectGroupBox.Name = "DBConnectGroupBox";
            this.DBConnectGroupBox.Size = new System.Drawing.Size(391, 59);
            this.DBConnectGroupBox.TabIndex = 5;
            this.DBConnectGroupBox.TabStop = false;
            this.DBConnectGroupBox.Text = "DB Connect String";
            // 
            // txtDBConnet
            // 
            this.txtDBConnet.Location = new System.Drawing.Point(8, 20);
            this.txtDBConnet.Name = "txtDBConnet";
            this.txtDBConnet.Size = new System.Drawing.Size(313, 21);
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
            this.CommServerGroupBox.Location = new System.Drawing.Point(6, 10);
            this.CommServerGroupBox.Name = "CommServerGroupBox";
            this.CommServerGroupBox.Size = new System.Drawing.Size(391, 115);
            this.CommServerGroupBox.TabIndex = 2;
            this.CommServerGroupBox.TabStop = false;
            this.CommServerGroupBox.Text = "Comm Server Setting";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(267, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(103, 21);
            this.txtPassword.TabIndex = 7;
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(71, 79);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(93, 21);
            this.txtAppName.TabIndex = 6;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(199, 31);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(92, 21);
            this.txtPort.TabIndex = 5;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(26, 31);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(126, 21);
            this.txtIP.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "App Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(232, 149);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 414);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.DBConnectGroupBox);
            this.Controls.Add(this.CommServerGroupBox);
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

