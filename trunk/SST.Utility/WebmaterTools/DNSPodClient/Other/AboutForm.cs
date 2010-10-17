using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DNSPodClient.Other
{
    public partial class AboutForm : Form
    {
        GBC _g;
        public AboutForm(GBC g)
        {
            _g = g;
            InitializeComponent();
            //this.Icon = DNSPodClient.Properties.Resources.DNSPod_1_Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "°æ±¾:" + _g.ReleaseVersion;
        }
    }
}