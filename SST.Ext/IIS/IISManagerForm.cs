using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Windows.Server.IIS;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;
using Silmoon.Windows;
using Silmoon.IO.SmFile;

namespace SST.Ext.IIS
{
    public partial class IISManagerForm : Form
    {
        GBC _g;
        IISManager _iisMgr = new IISManager();
        IISActionClass _iisac;
        public IISManagerForm(GBC g)
        {
            if (!Silmoon.Service.ServiceControl.IsExisted("W3SVC"))
            {
                MessageBox.Show("没有找到W3SVC服务，关闭！");
                Close();
                return;
            }
            _g = g;
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _iisac = new IISActionClass(_iisMgr);
            Show();
        }
        private void IISUtility_Shown(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread _draw_th = new Thread(DrawForm);
            _draw_th.IsBackground = true;
            _draw_th.Start();
        }

        private void DrawForm()
        {
            RefreshWebsiteListView();
        }


        private void 刷新网站列表RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshWebsiteListView();
        }
        private void 打开网站目录OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(_iisMgr.GetWebsiteInfo(_iisMgr.GetWebSiteID(ctlWebsitelv.SelectedItems[0].SubItems[0].Text)).DirectoryPath);
        }
        private void 删除选定站点DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string siteName = ctlWebsitelv.SelectedItems[0].SubItems[0].Text;
            string siteID = ctlWebsitelv.SelectedItems[0].SubItems[3].Text;
            if (MessageBox.Show("你真的要删除这个(" + siteName + ")(" + siteID + ")站点吗？", "确认！", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StartWork("尝试删除(" + siteName + ")...");
                try
                {
                    DeleteSiteResult result = _iisac.DeleteWebSite(siteID);
                    if (result.Error != null) _g.LoggerObj.WriteLogLine("(IIS)错误:" + result.Error);
                    if (result.SystemUserExist) _g.LoggerObj.WriteLogLine("(IIS)删除系统用户(" + result.SystemUsername + ")");

                    if (result.Success) _g.LoggerObj.WriteLogLine("(IIS)站点(" + result.WebSiteName + ")删除成功");
                    else _g.LoggerObj.WriteLogLine("(IIS)站点(" + result.WebSiteName + ")删除失败");

                    StartWork("刷新列表中...");
                    RefreshWebsiteListView();
                }
                catch { }
                StopWork();
            }
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            if (ctlWebsitelv.SelectedItems.Count == 0)
            {
                打开网站目录OToolStripMenuItem.Enabled = false;
                删除选定站点DToolStripMenuItem.Enabled = false;
            }
            else
            {
                打开网站目录OToolStripMenuItem.Enabled = true;
                删除选定站点DToolStripMenuItem.Enabled = true;
            }
        }

        private void ctlCreateNew_Click(object sender, EventArgs e)
        {
            CreateWebsiteForm createWindow = new CreateWebsiteForm(_g, _iisMgr);
            createWindow.WebsiteCreated += new IISHander(createWindow_WebsiteCreated);
        }
        private void ctlStartWebsite_Click(object sender, EventArgs e)
        {
            if (ctlWebsitelv.SelectedItems.Count != 0)
            {
                string webSiteID = ctlWebsitelv.SelectedItems[0].SubItems[3].Text;
                if (_iisMgr.GetWebSiteState(webSiteID) == WebSiteState.Stoped)
                {
                    StartWork("尝试启动...");

                    if (ctlWebsitelv.SelectedIndices != null)
                        _iisMgr.StartWebSite(webSiteID);
                    _g.LoggerObj.WriteLogLine("(IIS)启动站点:" + ctlWebsitelv.SelectedItems[0].SubItems[0].Text);

                    RefreshWebsiteListView();
                    StopWork();
                }
            }
        }
        private void ctlStopWebsite_Click(object sender, EventArgs e)
        {
            if (ctlWebsitelv.SelectedItems.Count != 0)
            {
                string webSiteID = ctlWebsitelv.SelectedItems[0].SubItems[3].Text;
                if (_iisMgr.GetWebSiteState(webSiteID) == WebSiteState.Running)
                {
                    StartWork("尝试停止...");

                    if (ctlWebsitelv.SelectedIndices != null)
                        _iisMgr.StopWebSite(webSiteID);
                    _g.LoggerObj.WriteLogLine("(IIS)停止站点:" + ctlWebsitelv.SelectedItems[0].SubItems[0].Text);
                    RefreshWebsiteListView();
                    StopWork();
                }
            }
        }

        private void ctlOpenIISMMC_Click(object sender, EventArgs e)
        {
            _g.TryOpenProcess(@"c:\windows\system32\inetsrv\iis.msc");
        }


        void RefreshWebsiteListView()
        {
            StartWork("刷新列表中...");
            try
            {
                WebSiteBaseInfo[] wsbaseInfo = _iisMgr.WebSiteList;
                ctlWebsitelv.Items.Clear();
                ctlWebsitelv.BeginUpdate();
                foreach (WebSiteBaseInfo binfo in wsbaseInfo)
                {
                    ctlWebsitelv.Items.Add(new ListViewItem(new string[] { binfo.SiteName, binfo.State.ToString(), binfo.AppPoolName, binfo.SiteID }));
                }
                ctlWebsitelv.EndUpdate();
            }
            catch { }
            StopWork();
        }
        void StartWork()
        {
            this.Text = "IIS 管理 (进程中...)";
        }
        void StartWork(string s)
        {
            this.Text = "IIS 管理 (进程中..." + s + ")";
        }
        void StopWork()
        {
            this.Text = "IIS 管理";
        }
        void createWindow_WebsiteCreated(string webSiteName)
        {
            _g.LoggerObj.WriteLogLine("(IIS)创建站点完成:" + webSiteName);
            RefreshWebsiteListView();
        }


        #region 外部操作
        public void CreateWebsite()
        {
            ctlCreateNew_Click(null, null);
        }
        #endregion

        private void ctlBindingsButton_Click(object sender, EventArgs e)
        {
            new BindingsListForm(_iisMgr).Show();
        }
    }
}