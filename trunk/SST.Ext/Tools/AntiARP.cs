using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace SST.Ext.Tools
{
    public partial class AntiARP : Form
    {
        GBC _g;
        Security.ModuleSecuritySettingsClass moduleSecurity;
        public AntiARP(GBC g)
        {
            _g = g;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            moduleSecurity = new SST.Ext.Security.ModuleSecuritySettingsClass(_g);
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moduleSecurity.InstallAntiARP();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            moduleSecurity.UninstallAntiARP();
        }

        private void AntiARP_FormClosed(object sender, FormClosedEventArgs e)
        {
            moduleSecurity = null;
        }
    }
}