using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Silmoon.Windows.Server.IIS;
using System.Collections;
using System.IO;

namespace SST.Ext.IIS.IISLog
{
    public partial class LogSelectSiteFilesForm : Form
    {
        IISManager _iisMgr = new IISManager();
        ArrayList _needReturnedFiles;
        string _selectedWebSiteDirectory;
        long _selectedFileLengthMB = 0;

        public LogSelectSiteFilesForm(ref ArrayList returnedFiles)
        {
            _needReturnedFiles = returnedFiles;
            InitializeComponent();
        }
        void ExecAsync(ThreadStart start)
        {
            Thread _th = new Thread(start);
            _th.IsBackground = true;
            _th.Start();
        }

        private void LogSelectSiteFiles_Shown(object sender, EventArgs e)
        {
            ExecAsync(listWebSite);
        }
        private void LogSelectSiteFiles_FormClosed(object sender, FormClosedEventArgs e)
        {
            _iisMgr.Dispose();
            _iisMgr = null;
        }

        void listWebSite()
        {
            ctlWebSiteListBox.Items.Clear();
            WebSiteBaseInfo[] baseinfos = _iisMgr.WebSiteList;
            foreach (WebSiteBaseInfo baseinfo in baseinfos)
            {
                ctlWebSiteListBox.Items.Add(baseinfo.SiteName + "(" + baseinfo.SiteID + ")");
            }
        }

        private void ctlWebSiteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string webSiteID = ctlWebSiteListBox.SelectedItem.ToString().Split(new string[] { "(", ")" }, StringSplitOptions.None)[1];
            string SiteLogDirectory = _iisMgr.GetWebSiteParameter(webSiteID, WebSiteParameter.LogFileDirectory).ToString();
            ctlLogFileListBox.Items.Clear();
            if (Directory.Exists(SiteLogDirectory + "\\W3SVC" + webSiteID))
            {
                _selectedWebSiteDirectory = SiteLogDirectory + "\\W3SVC" + webSiteID + "\\";
                string[] files = Directory.GetFiles(SiteLogDirectory + "\\W3SVC" + webSiteID, "*.log");
                foreach (string file in files)
                {
                    ctlLogFileListBox.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void ctlConfirmButton_Click(object sender, EventArgs e)
        {
            if (ctlLogFileListBox.SelectedItems.Count != 0)
            {
                if (_selectedFileLengthMB > 200 && MessageBox.Show("��ѡ����ļ�������200MB\r\n�ڷ�����ʱ�������������û�����κι��ˣ����ܻ������б����\r\n����������Ŀ�����ұ������ռ�ô����ڴ�Ӷ�������ò��ȶ���\r\n������", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                _needReturnedFiles.Clear();
                foreach (object obj in ctlLogFileListBox.SelectedItems)
                {
                    _needReturnedFiles.Add(_selectedWebSiteDirectory + obj.ToString());
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("û��ѡ���κ��ļ���", "_war", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ctlLogFileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            long filesLengthTotal = 0;
            foreach (string file in ctlLogFileListBox.SelectedItems)
            {
                try
                {
                    FileInfo info = new FileInfo(_selectedWebSiteDirectory + file);
                    filesLengthTotal += info.Length;
                }
                catch { }
            }
            _selectedFileLengthMB = filesLengthTotal / 1048576;

            label1.Text = "ȫ���ļ���С " + _selectedFileLengthMB + "MB";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}