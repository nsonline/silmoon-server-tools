using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SST.Ext.Server
{
    public partial class HServerModule : Form
    {
        GBC _g;
        Security.ModuleSecuritySettingsClass modulesecClass;
        public HServerModule(GBC g)
        {
            _g = g;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            modulesecClass = new SST.Ext.Security.ModuleSecuritySettingsClass(_g);
            Show();
        }

        private void UnRegAll_Click(object sender, EventArgs e)
        {
            modulesecClass.UninstallUnSecurityMobule();
        }
        private void RegButton_Click(object sender, EventArgs e)
        {
            modulesecClass.InstallUnSecurityMobule();
        }
    }
}