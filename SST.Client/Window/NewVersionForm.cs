using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SST.Client.Window
{
    public partial class NewVersionForm : Form
    {
        GBC g = null;
        public NewVersionForm(GBC g)
        {
            this.g = g;
            InitializeComponent();
            Show((IWin32Window)g.MainForm);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.cookydns.com/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://client.silmoon.com/cookydns.jpg");
        }
    }
}