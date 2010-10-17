using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;
using SST.Ext.IIS.IISLog;

namespace SST.Ext.IIS.IISLog
{
    public partial class LogAnalysisForm : Form
    {
        ArrayList _threadedAnalysisFiles = new ArrayList();

        ArrayList _logArray = new ArrayList();
        ArrayList _showLog = new ArrayList();

        public LogAnalysisForm()
        {
            if (!Silmoon.Service.ServiceControl.IsExisted("W3SVC"))
            {
                MessageBox.Show("没有找到W3SVC服务，关闭！");
                Close();
                return;
            }
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Show();
        }

        private void 单文件分析SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "IIS日志文件|*.log";
            if (ofd.ShowDialog() == DialogResult.OK || File.Exists(ofd.FileName))
            {
                _threadedAnalysisFiles.Clear();
                _threadedAnalysisFiles.Add(ofd.FileName);
                ExecAsync(analysisFile);
            }
        }

        void analysisFile()
        {
            ctlLogListView.VirtualListSize = 0;
            _logArray.Clear();
            int fileCount = 0;
            ctlStatusProceBar.Visible = true;

            foreach (string logFilePath in (string[])_threadedAnalysisFiles.ToArray(typeof(string)))
            {
                try
                {
                    fileCount++;
                    FileStream fstream = File.Open(logFilePath, FileMode.Open);

                    long fileLength = fstream.Length;
                    byte[] byteBuffer = new byte[1024000];
                    long realTotal = 0;
                    long realResultCount = 0;
                    string beforeString = string.Empty;

                    ctlStatusText.Text = "开始分析...";

                    ctlLogListView.VirtualListSize = _logArray.Count;

                    while ((realResultCount = fstream.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                    {
                        ctlStatusText.Text = "分析位置 " + realTotal + "(" + realTotal / 1048576 + "MB)" + " /" + fileLength + "(" + fileLength / 1048576 + "MB)" + " ,文件句柄缓存块大小(" + realResultCount + "),第" + fileCount + "/" + _threadedAnalysisFiles.Count + "个文件(" + Path.GetFileName(logFilePath) + ")";
                        ctlStatusProceBar.Value = (int)(((double)realTotal / (double)fileLength) * 100);

                        realTotal += realResultCount;
                        string bufferString = Encoding.Default.GetString(byteBuffer);
                        int returnCharIndex = bufferString.LastIndexOf("\r\n");
                        string needAnalysisString = beforeString + bufferString.Substring(0, returnCharIndex);

                        string[] analysisLines = needAnalysisString.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string line in analysisLines)
                        {
                            if (line.Substring(0, 1) != "#")
                            {
                                try
                                {
                                    string[] lineSplited = line.Split(new string[] { " " }, StringSplitOptions.None);
                                    LogDataStruct log = new LogDataStruct();
                                    log.datetime = lineSplited[0] + "/" + lineSplited[1];
                                    log.method = lineSplited[4];
                                    log.dsturl = lineSplited[5];
                                    log.clientip = lineSplited[9];
                                    log.ua = lineSplited[10];
                                    log.statuscode = lineSplited[11];
                                    _logArray.Add(log);
                                }
                                catch { }
                            }
                        }
                        ctlLogListView.VirtualListSize = _logArray.Count;
                        beforeString = bufferString.Substring(returnCharIndex, bufferString.Length - returnCharIndex);
                    }
                    ctlStatusText.Text = "分析完毕，" + _threadedAnalysisFiles.Count + "个文件中有" + _logArray.Count + "条纪录。";

                    fstream.Close();
                    fstream.Dispose();
                    ctlLogListView.VirtualListSize = _logArray.Count;
                }
                catch (Exception ex) { MessageBox.Show("在分析时遇到错误！\r\n错误：\r\n\t" + ex.ToString()); }
            }
            ctlStatusProceBar.Visible = false;
            uncheckAllToolBar(null);
        }

        private void ctlLogListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            LogDataStruct log;
            if (_showLog.Count == 0)
                log = (LogDataStruct)_logArray[e.ItemIndex];
            else
                log = (LogDataStruct)_showLog[e.ItemIndex];
            e.Item = new ListViewItem(new string[] { log.datetime, log.method, log.dsturl, log.clientip, log.ua, log.statuscode });
        }

        private void ctlOnlySpiderRecordButton_Click(object sender, EventArgs e)
        {
            _showLog.Clear();
            if (!((ToolStripButton)sender).Checked)
            {
                ctlLogListView.VirtualListSize = 0;
                foreach (LogDataStruct unit in _logArray)
                {
                    if (unit.ua.ToLower().IndexOf("spider") != -1)
                        _showLog.Add(unit);
                }
                ctlLogListView.VirtualListSize = _showLog.Count;
                uncheckAllToolBar((ToolStripButton)sender);
            }
            else
            {
                ctlLogListView.VirtualListSize = _logArray.Count;
                uncheckAllToolBar(null);
            }
        }
        private void ctlOnlyBaiduSpiderButton_Click(object sender, EventArgs e)
        {
            _showLog.Clear();
            if (!((ToolStripButton)sender).Checked)
            {
                ctlLogListView.VirtualListSize = 0;
                foreach (LogDataStruct unit in _logArray)
                {
                    if (unit.ua.ToLower().IndexOf("baiduspider") != -1)
                        _showLog.Add(unit);
                }
                ctlLogListView.VirtualListSize = _showLog.Count;
                uncheckAllToolBar((ToolStripButton)sender);
            }
            else
            {
                ctlLogListView.VirtualListSize = _logArray.Count;
                uncheckAllToolBar(null);
            }
        }
        private void ctlOnlyGoogleSpiderButton_Click(object sender, EventArgs e)
        {
            _showLog.Clear();
            if (!((ToolStripButton)sender).Checked)
            {
                ctlLogListView.VirtualListSize = 0;
                foreach (LogDataStruct unit in _logArray)
                {
                    if (unit.ua.ToLower().IndexOf("googlebot") != -1)
                        _showLog.Add(unit);
                }
                ctlLogListView.VirtualListSize = _showLog.Count;
                uncheckAllToolBar((ToolStripButton)sender);
            }
            else
            {
                ctlLogListView.VirtualListSize = _logArray.Count;
                uncheckAllToolBar(null);
            }
        }
        private void ctltOnly4Button_Click(object sender, EventArgs e)
        {
            _showLog.Clear();
            if (!((ToolStripButton)sender).Checked)
            {
                ctlLogListView.VirtualListSize = 0;
                foreach (LogDataStruct unit in _logArray)
                {
                    if (unit.statuscode[0] == char.Parse("4"))
                        _showLog.Add(unit);
                }
                ctlLogListView.VirtualListSize = _showLog.Count;
                uncheckAllToolBar((ToolStripButton)sender);
            }
            else
            {
                ctlLogListView.VirtualListSize = _logArray.Count;
                uncheckAllToolBar(null);
            }
        }
        private void ctltOnly3Button_Click(object sender, EventArgs e)
        {
            _showLog.Clear();
            if (!((ToolStripButton)sender).Checked)
            {
                ctlLogListView.VirtualListSize = 0;
                foreach (LogDataStruct unit in _logArray)
                {
                    if (unit.statuscode[0] == char.Parse("3"))
                        _showLog.Add(unit);
                }
                ctlLogListView.VirtualListSize = _showLog.Count;
                uncheckAllToolBar((ToolStripButton)sender);
            }
            else
            {
                ctlLogListView.VirtualListSize = _logArray.Count;
                uncheckAllToolBar(null);
            }
        }
        private void ctltOnly2Button_Click(object sender, EventArgs e)
        {
            _showLog.Clear();
            if (!((ToolStripButton)sender).Checked)
            {
                ctlLogListView.VirtualListSize = 0;
                foreach (LogDataStruct unit in _logArray)
                {
                    if (unit.statuscode[0] == char.Parse("2"))
                        _showLog.Add(unit);
                }
                ctlLogListView.VirtualListSize = _showLog.Count;
                uncheckAllToolBar((ToolStripButton)sender);
            }
            else
            {
                ctlLogListView.VirtualListSize = _logArray.Count;
                uncheckAllToolBar(null);
            }
        }
        private void ctltOnly5Button_Click(object sender, EventArgs e)
        {
            _showLog.Clear();
            if (!((ToolStripButton)sender).Checked)
            {
                ctlLogListView.VirtualListSize = 0;
                foreach (LogDataStruct unit in _logArray)
                {
                    if (unit.statuscode[0] == char.Parse("5"))
                        _showLog.Add(unit);
                }
                ctlLogListView.VirtualListSize = _showLog.Count;
                uncheckAllToolBar((ToolStripButton)sender);
            }
            else
            {
                ctlLogListView.VirtualListSize = _logArray.Count;
                uncheckAllToolBar(null);
            }
        }
        void uncheckAllToolBar(ToolStripButton needCheck)
        {
            ctltOnly2Button.Checked = false;
            ctltOnly3Button.Checked = false;
            ctltOnly4Button.Checked = false;
            ctltOnly5Button.Checked = false;
            ctlOnlySpiderRecordButton.Checked = false;
            ctlOnlyGoogleSpiderButton.Checked = false;
            ctlOnlyBaiduSpiderButton.Checked = false;
            if (needCheck != null)
                needCheck.Checked = true;
        }

        void ExecAsync(ThreadStart start)
        {
            Thread _th = new Thread(start);
            _th.IsBackground = true;
            _th.Start();
        }

        private void 从网站分析WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogSelectSiteFilesForm selectSiteFrm = new LogSelectSiteFilesForm(ref _threadedAnalysisFiles);
            if (selectSiteFrm.ShowDialog() == DialogResult.OK)
            {
                ExecAsync(analysisFile);
            }
        }
        private void 分析过滤器FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LogFilterOptions().ShowDialog();
        }

    }
   
    internal class LogDataStruct
    {
        public string datetime;
        public string method;
        public string dsturl;
        public string clientip;
        public string ua;
        public string statuscode;
    }
}