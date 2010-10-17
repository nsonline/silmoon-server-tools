using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SST.Ext.IIS;

namespace SST.Client.FormControls
{
    public partial class GeneralPageControl : SST.Controls.MainFormTemplate
    {
        public GeneralPageControl()
        {
            InitializeComponent();
        }

        private void EditPhpini_Click(object sender, EventArgs e)
        {
            try { new PhpIniEditClass(_g); }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        private void DlDetect_Click(object sender, EventArgs e)
        {
            new MessageBoxs.DownloadWebDetect(_g);
        }

        private void SmSvrServLog_Click(object sender, EventArgs e)
        {
            new SST.Ext.Server.SmSvrServ.LogView(_g);
        }

        private void SmSvrServOptions_Click(object sender, EventArgs e)
        {
            new SST.Ext.Server.SmSvrServ.SmSvrServForm(_g);
        }

        private void ctlCreateWebsiteButton_Click(object sender, EventArgs e)
        {
            SST.Ext.IIS.IISManagerForm iisu = new IISManagerForm(_g);
            if (!iisu.IsDisposed) { iisu.CreateWebsite(); }
        }

        private void ctlIISPerfCountViewButton_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.Performance.IISPerformanceViewList(_g);
        }

        private void ctlIISBackupButton_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.IISBackupForm(_g);
        }

        private void ctlIISManagerButton_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.IISManagerForm(_g);
        }

        private void ctlAppPoolManagerButton_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.Performance.ApplicationPoolManagerForm();
        }

        private void ctlIISLogButton_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.IISLog.LogAnalysisForm();
        }
    }
}
