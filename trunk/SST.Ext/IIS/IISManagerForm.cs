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
                MessageBox.Show("û���ҵ�W3SVC���񣬹رգ�");
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


        private void ˢ����վ�б�RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshWebsiteListView();
        }
        private void ����վĿ¼OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(_iisMgr.GetWebsiteInfo(_iisMgr.GetWebSiteID(ctlWebsitelv.SelectedItems[0].SubItems[0].Text)).DirectoryPath);
        }
        private void ɾ��ѡ��վ��DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string siteName = ctlWebsitelv.SelectedItems[0].SubItems[0].Text;
            string siteID = ctlWebsitelv.SelectedItems[0].SubItems[3].Text;
            if (MessageBox.Show("�����Ҫɾ�����(" + siteName + ")(" + siteID + ")վ����", "ȷ�ϣ�", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StartWork("����ɾ��(" + siteName + ")...");
                try
                {
                    DeleteSiteResult result = _iisac.DeleteWebSite(siteID);
                    if (result.Error != null) _g.LoggerObj.WriteLogLine("(IIS)����:" + result.Error);
                    if (result.SystemUserExist) _g.LoggerObj.WriteLogLine("(IIS)ɾ��ϵͳ�û�(" + result.SystemUsername + ")");

                    if (result.Success) _g.LoggerObj.WriteLogLine("(IIS)վ��(" + result.WebSiteName + ")ɾ���ɹ�");
                    else _g.LoggerObj.WriteLogLine("(IIS)վ��(" + result.WebSiteName + ")ɾ��ʧ��");

                    StartWork("ˢ���б���...");
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
                ����վĿ¼OToolStripMenuItem.Enabled = false;
                ɾ��ѡ��վ��DToolStripMenuItem.Enabled = false;
            }
            else
            {
                ����վĿ¼OToolStripMenuItem.Enabled = true;
                ɾ��ѡ��վ��DToolStripMenuItem.Enabled = true;
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
                    StartWork("��������...");

                    if (ctlWebsitelv.SelectedIndices != null)
                        _iisMgr.StartWebSite(webSiteID);
                    _g.LoggerObj.WriteLogLine("(IIS)����վ��:" + ctlWebsitelv.SelectedItems[0].SubItems[0].Text);

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
                    StartWork("����ֹͣ...");

                    if (ctlWebsitelv.SelectedIndices != null)
                        _iisMgr.StopWebSite(webSiteID);
                    _g.LoggerObj.WriteLogLine("(IIS)ֹͣվ��:" + ctlWebsitelv.SelectedItems[0].SubItems[0].Text);
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
            StartWork("ˢ���б���...");
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
            this.Text = "IIS ���� (������...)";
        }
        void StartWork(string s)
        {
            this.Text = "IIS ���� (������..." + s + ")";
        }
        void StopWork()
        {
            this.Text = "IIS ����";
        }
        void createWindow_WebsiteCreated(string webSiteName)
        {
            _g.LoggerObj.WriteLogLine("(IIS)����վ�����:" + webSiteName);
            RefreshWebsiteListView();
        }


        #region �ⲿ����
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