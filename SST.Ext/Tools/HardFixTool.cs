using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SST.Ext.Tools.Classes;

namespace SST.Ext.Tools
{
    public partial class HardFixTool : Form
    {
        GBC _g;
        public HardFixTool(GBC g)
        {
            _g = g;
            InitializeComponent();
            Icon = SST.Resource.Resource.SSTIco2;
            Show();
        }

        private void b_FixWindowsInstallCopyFiles_Click(object sender, EventArgs e)
        {
            HardFixClass.FixWindowsInstallCopyFile();
        }
    }
}