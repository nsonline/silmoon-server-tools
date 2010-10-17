using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using SST.Utility;

namespace SST.Utility
{
    public class ResourceUnit : IDisposable
    {
        GBC _g;
        ListBox _lb;
        int _index;
        ServerPlusDownloader fm1;
        public bool _isDispose = false;
        public bool _isDownloading = false;
        public bool _isDownloaded = false;
        WebClient _wclt;
        public string _url;
        public string _name;

        public ResourceUnit(string resourceLine, ListBox lb, int index, GBC g, ServerPlusDownloader fm)
        {
            string[] s = resourceLine.Split(new string[] { "|||" }, StringSplitOptions.None);
            _url = s[0];
            _name = s[1];
            _lb = lb;
            _index = index;
            _g = g;
            fm1 = fm;
        }

        public void StartDownLoad()
        {
            try
            {
                Directory.CreateDirectory(_g.Pathinfo.ResourceDir + "Downloaded\\");
                _wclt = new WebClient();
                _wclt.DownloadProgressChanged += new DownloadProgressChangedEventHandler(_wclt_DownloadProgressChanged);
                _wclt.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(_wclt_DownloadFileCompleted);
                _wclt.DownloadFileAsync(new Uri(_url), _g.Pathinfo.ResourceDir + "Downloaded\\" + Path.GetFileName(_url));
                _isDownloading = true;
                _g.LoggerObj.WriteLogLine("开始下载" + _name + "...");
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }
        public void AbortDownLoad()
        {
            if (_isDownloading) _wclt.CancelAsync();
        }

        void _wclt_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            _lb.Items[_index] = _name + " (" + e.ProgressPercentage + "%)";

            if (fm1.C_ResourceListListBox.SelectedIndex == _index)
                fm1.C_StatusProcBar.Value = e.ProgressPercentage;
        }
        void _wclt_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            _isDownloading = false;

            if (!e.Cancelled)
            {
                _isDownloaded = true;
                fm1.C_StartButton.Enabled = false;
                fm1.C_CancelButton.Enabled = false;
                fm1.C_OpenButton.Enabled = true;
                _wclt.Dispose();
                _g.LoggerObj.WriteLogLine("完成下载" + _name + "！");
                _wclt.DownloadProgressChanged -= new DownloadProgressChangedEventHandler(_wclt_DownloadProgressChanged);
                _wclt.DownloadFileCompleted -= new System.ComponentModel.AsyncCompletedEventHandler(_wclt_DownloadFileCompleted);
            }
            else
            {
                fm1.C_StartButton.Enabled = true;
                fm1.C_CancelButton.Enabled = false;
                _lb.Items[_index] = _name + " (Canceled)";
                _g.LoggerObj.WriteLogLine("取消下载" + _name + "！");
            }
        }
        #region IDisposable 成员

        public void Dispose()
        {
            _isDispose = true;
            if (_isDownloading) { _wclt.CancelAsync(); }
            if (_wclt != null)
            {
                _wclt.DownloadProgressChanged -= new DownloadProgressChangedEventHandler(_wclt_DownloadProgressChanged);
                _wclt.DownloadFileCompleted -= new System.ComponentModel.AsyncCompletedEventHandler(_wclt_DownloadFileCompleted);
                _wclt.Dispose();
            }
        }

        #endregion
    }
}
