using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SST.Client.Window
{
    public partial class AboutForm : Form
    {
        GBC _g;
        public AboutForm(GBC g)
        {
            _g = g;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label2.Text += _g.GetAppVersion.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left) System.Diagnostics.Process.Start("http://user.qzone.qq.com/1707710/blog/1241436294");
        }
    }
}