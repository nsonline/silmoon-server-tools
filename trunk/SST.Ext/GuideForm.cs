using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using System.IO;

namespace SST.Ext
{
    public partial class GuideForm : Form
    {
        GBC _g;
        ArrayList _guideArr = new ArrayList();
        public GuideForm(GBC g)
        {
            _g = g;
            InitializeComponent();
            Show();
        }
        private void GuideForm_Load(object sender, EventArgs e)
        {
            this.Icon = SST.Resource.Resource.SSTIco2;
            WebClient _w = new WebClient();
            _w.DownloadFileCompleted += new AsyncCompletedEventHandler(_w_DownloadFileCompleted);
            _w.DownloadFileAsync(new Uri(_g.Pathinfo.RemoteGuideList), _g.Pathinfo.ResourceDir + "GuideList.tdat");
        }

        void _w_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            ((WebClient)sender).Dispose();
            label1.Visible = false;
            string[] _garr = File.ReadAllLines(_g.Pathinfo.ResourceDir + "GuideList.tdat", Encoding.Default);
            foreach (string s in _garr)
            {
                GuideUnit gu;
                gu.Name = s.Split(new string[] { "|" }, StringSplitOptions.None)[0];
                gu.URL = s.Split(new string[] { "|" }, StringSplitOptions.None)[1];
                _guideArr.Add(gu);
                listBox1.Items.Add(gu.Name);
            }
            File.Delete(_g.Pathinfo.ResourceDir + "GuideList.tdat");
        }

        private void GuideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Uri newUri = new Uri(((GuideUnit)_guideArr[listBox1.SelectedIndex]).URL);
            if (webBrowser1.Url != newUri)
                webBrowser1.Url = newUri;
        }
        private void 刷新RToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh(WebBrowserRefreshOption.Completely);
        }
        private void 后退BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void 前进FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void 帮助首页HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 1;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            label1.Text = "装载中...";
            label1.Visible = true;
        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            label1.Visible = false;
        }
    }
    struct GuideUnit
    {
        public string Name;
        public string URL;
    }
}