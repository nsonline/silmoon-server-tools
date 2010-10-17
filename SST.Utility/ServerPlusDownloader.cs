using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace SST.Utility
{
    public partial class ServerPlusDownloader : Form
    {
        ArrayList _resourceListArr = new ArrayList();
        GBC _g;
        public ServerPlusDownloader(GBC g)
        {
            _g = g;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void C_ReadResourceButton_Click(object sender, EventArgs e)
        {
            WebClient _rcclit = new WebClient();
            _rcclit.DownloadFileCompleted += new AsyncCompletedEventHandler(_rcclit_DownloadFileCompleted);
            C_ReadResourceButton.Enabled = false;
            label1.Text = "读取SST服务器提供的资源...";
            _rcclit.DownloadFileAsync(new Uri(_g.Pathinfo.RemoteResourceList), _g.Pathinfo.ResourceDir + "DownloadResource.tdat");
        }
        void _rcclit_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
                FillList();
            else
                label1.Text = e.Error.Message;
            }

        private void FillList()
        {
            label1.Text = "完成读取。";
            C_ResourceListListBox.Items.Clear();
            foreach (string s in File.ReadAllLines(_g.Pathinfo.ResourceDir + "DownloadResource.tdat", Encoding.Default))
            {
                C_ResourceListListBox.BeginUpdate();
                if (s.Substring(0, 1) != ";")
                {
                    ResourceUnit u = new ResourceUnit(s, C_ResourceListListBox, C_ResourceListListBox.Items.Count, _g, this);
                    _resourceListArr.Add(u);
                    C_ResourceListListBox.Items.Add(u._name);
                }
                C_ResourceListListBox.EndUpdate();
            }
            File.Delete(_g.Pathinfo.ResourceDir + "DownloadResource.tdat");
        }

        private void C_StartButton_Click(object sender, EventArgs e)
        {
            ResourceUnit _u = (ResourceUnit)_resourceListArr[C_ResourceListListBox.SelectedIndex];
            _u.StartDownLoad();
        }
        private void C_CancelButton_Click(object sender, EventArgs e)
        {
            if (C_ResourceListListBox.SelectedIndex != -1)
            {
                ResourceUnit u = (ResourceUnit)_resourceListArr[C_ResourceListListBox.SelectedIndex];
                if (u._isDownloading)
                {
                    u.AbortDownLoad();
                    C_StartButton.Enabled = true;
                    C_CancelButton.Enabled = false;
                }
            }
        }
        private void C_OpenButton_Click(object sender, EventArgs e)
        {
            if (C_ResourceListListBox.SelectedIndex != -1)
            {
                ResourceUnit u = (ResourceUnit)_resourceListArr[C_ResourceListListBox.SelectedIndex];
                if (u._isDownloaded)
                {
                    try
                    {
                        Process.Start(_g.Pathinfo.ResourceDir + "Downloaded\\" + Path.GetFileName(u._url));
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void C_ResourceListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_ResourceListListBox.SelectedIndex != -1)
            {
                ResourceUnit u = (ResourceUnit)_resourceListArr[C_ResourceListListBox.SelectedIndex];
                if (u._isDownloading)
                {
                    C_StartButton.Enabled = false;
                    C_CancelButton.Enabled = true;
                    C_OpenButton.Enabled = false;
                }
                else
                {
                    if (u._isDownloaded)
                    {
                        C_StartButton.Enabled = false;
                        C_CancelButton.Enabled = false;
                        C_OpenButton.Enabled = true;
                        C_StatusProcBar.Value = 100;
                    }
                    else if (!u._isDownloaded && !u._isDownloading)
                    {
                        C_StartButton.Enabled = true;
                        C_CancelButton.Enabled = false;
                        C_OpenButton.Enabled = false;
                        C_StatusProcBar.Value = 0;
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("退出？？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < _resourceListArr.Count; i++)
                {
                    ResourceUnit ru = (ResourceUnit)_resourceListArr[i];
                    if (ru._isDownloading)
                        ru.AbortDownLoad();
                    ru.Dispose();
                }
                if (_resourceListArr.Count != 0)
                {
                    if (MessageBox.Show("清空临时文件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            if (Directory.Exists(_g.Pathinfo.ResourceDir + "Downloaded\\")) Directory.Delete(_g.Pathinfo.ResourceDir + "Downloaded\\", true);
                            Directory.CreateDirectory(_g.Pathinfo.ResourceDir + "Downloaded\\");
                        }
                        catch { }
                    }
                }
                Dispose(true);
            }
            else e.Cancel = true;
        }

        private void 清空临时文件CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _resourceListArr.Count; i++)
            {
                ResourceUnit ru = (ResourceUnit)_resourceListArr[i];
                ru._isDownloaded = false;
                ru._isDownloading = false;
            }
            try
            {
                if (Directory.Exists(_g.Pathinfo.ResourceDir + "Downloaded\\")) Directory.Delete(_g.Pathinfo.ResourceDir + "Downloaded\\", true);
                Directory.CreateDirectory(_g.Pathinfo.ResourceDir + "Downloaded\\");
            }
            catch { }
            _g.LoggerObj.WriteLogLine("资源临时文件已被清空...");
        }
    }
}