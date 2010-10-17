using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SST.Client.MessageBoxs
{
    public partial class DownloadWebDetect : Form
    {
        GBC _g;
        public DownloadWebDetect(GBC g)
        {
            _g = g;
            InitializeComponent();
            ShowDialog();
        }

        private void DownloadWebDetect_Load(object sender, EventArgs e)
        {
            this.Icon = SST.Resource.Resource.SSTIco2;
        }

        private void ASP_Click(object sender, EventArgs e)
        {
            new SST.Ext.DownloadFileToDirectory(_g, "asp.asp", "asp", _g.Pathinfo.RemoteSSTFile + "asp.txt");
            Close();
        }
        private void ASPNET_Click(object sender, EventArgs e)
        {
            new SST.Ext.DownloadFileToDirectory(_g, "aspx.aspx", "aspx", _g.Pathinfo.RemoteSSTFile + "aspx.txt");
            Close();
        }
        private void PHP_Click(object sender, EventArgs e)
        {
            new SST.Ext.DownloadFileToDirectory(_g, "php.php", "php", _g.Pathinfo.RemoteSSTFile + "php.txt");
            Close();
        }
    }
}