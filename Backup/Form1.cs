using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace IniDemo
{
    public partial class Form1 : Form
    {
        public string IP, Port, AppName, Password, DBConnectString, gameWinRateUpDown, killRateUpDown;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            IP = txtIP.Text;
            Port = txtPort.Text;
            AppName = txtAppName.Text;
            Password = txtPassword.Text;
            DBConnectString = txtDBConnet.Text;
            gameWinRateUpDown = GameWinRateUpDown.Text;
            killRateUpDown = KillRateUpDown.Text;
            StreamWriter sw = new StreamWriter("game.ini", false, Encoding.GetEncoding("gb2312"));
            sw.Flush();
            sw.WriteLine(IP);
            sw.WriteLine(Port);
            sw.WriteLine(AppName);
            sw.WriteLine(Password);
            sw.WriteLine(DBConnectString);
            sw.WriteLine(gameWinRateUpDown);
            sw.WriteLine(killRateUpDown);
            sw.Close();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("game.ini", Encoding.GetEncoding("gb2312"));
            if (sr.Peek() >= 0)
            {
                txtIP.Text = sr.ReadLine();
                txtPort.Text = sr.ReadLine();
                txtAppName.Text = sr.ReadLine();
                txtPassword.Text = sr.ReadLine();
                txtDBConnet.Text = sr.ReadLine();
                GameWinRateUpDown.Text = sr.ReadLine();
                KillRateUpDown.Text = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
