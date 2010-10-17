using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.Web;
using System.Threading;
using System.Diagnostics;
using Silmoon.Security;

namespace DNSPodClient
{
    public partial class Login : Form
    {
        GBC _g = new GBC();
        public Login()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //this.Icon = DNSPodClient.Properties.Resources.DNSPod_1_Red;
        }

        private void ctlLoginButton_Click(object sender, EventArgs e)
        {
            ctlLoginButton.Enabled = false;
            ExecAsync(_th_checklogin);
            linkLabel2.Focus();
        }

        void dlist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        void ExecAsync(ThreadStart start)
        {
            Thread _th = new Thread(start);
            _th.IsBackground = true;
            _th.Start();
        }

        private void DoLogin()
        {
            _g.Username = ctlUsernameTextBox.Text;
            _g.Password = ctlPasswordTextBox.Text;
            if (ctlSaveLoginCheckBox.Checked)
            {
                _g.Ini.WriteInivalue("DNSPod", "Username", _g.Encrypt.Encrypto(_g.Username));
                _g.Ini.WriteInivalue("DNSPod", "Password", _g.Encrypt.Encrypto(_g.Password));
            }
            DomainsListForm dlist = new DomainsListForm(_g);
            dlist.FormClosed += new FormClosedEventHandler(dlist_FormClosed);
            Hide();
        }
        void _th_checklogin()
        {
            if (_g._dnspod.Login(ctlUsernameTextBox.Text, ctlPasswordTextBox.Text).DoubleStateFlag)
                this.Invoke(new ThreadStart(DoLogin));
            else MessageBox.Show(this, "登陆失败", "_war", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctlLoginButton.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Process.Start("https://www.dnspod.com/");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Process.Start("http://www.silmoon.com/silmoon?come=app_DNSPodClient1");
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            if (_g.Ini.ReadInivalue("DNSPod", "Username") != null)
            {
                ctlUsernameTextBox.Text = _g.Encrypt.Decrypto(_g.Ini.ReadInivalue("DNSPod", "Username"));
            }
            if (_g.Ini.ReadInivalue("DNSPod", "Password") != null)
            {
                ctlPasswordTextBox.Text = _g.Encrypt.Decrypto(_g.Ini.ReadInivalue("DNSPod", "Password"));
            }
        }

        private void ctlSaveLoginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ctlSaveLoginCheckBox.Checked)
            {
                _g.Ini.WriteInivalue("DNSPod", "Username", _g.Encrypt.Encrypto(""));
                _g.Ini.WriteInivalue("DNSPod", "Password", _g.Encrypt.Encrypto(""));
            }
        }
    }
}