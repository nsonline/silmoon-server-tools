using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SST.Ext
{
    public class DownloadFileToDirectory : IDisposable
    {
        GBC _g;
        string _extName = "";
        string _uri = "";
        string _fileName = "";
        bool _confirm = false;
        public DownloadFileToDirectory(GBC g, string Filename, string ExtName, string uri)
        {
            _extName = ExtName;
            _g = g;
            _uri = uri;
            _fileName = Filename;
            string selectPath = SelectedPath();

            if (_confirm)
            {
                if (selectPath != "")
                {
                    try
                    {
                        WebClient _wclit = new WebClient();
                        _wclit.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(_wclit_DownloadFileCompleted);
                        _wclit.DownloadFileAsync(new Uri(_uri), selectPath);
                    }
                    catch (WebException e)
                    {
                        _g.Tray.ShowBalloonTip(1000, "错误", "错误：\r\n" + e.Message, ToolTipIcon.Error);
                    }
                }
            }
            else Dispose();
        }

        void _wclit_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                _g.LoggerObj.WriteLogLine("文件 " + Path.GetFileName(_fileName) + " 下载完毕..");
                _g.Tray.ShowBalloonTip(1000, "提示", "文件 " + Path.GetFileName(_fileName) + " 下载完毕..", ToolTipIcon.Info);
            }
            else
            {
                _g.LoggerObj.WriteLogLine("文件 " + Path.GetFileName(_fileName) + " 下载错误..");
                _g.Tray.ShowBalloonTip(1000, "提示", "文件 " + Path.GetFileName(_fileName) + " 下载错误..", ToolTipIcon.Error);
            }
            ((WebClient)sender).Dispose();
            Dispose();
        }

        private string SelectedPath()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileOk += new System.ComponentModel.CancelEventHandler(sfd_FileOk);
            if (_extName != "") sfd.Filter = _extName + "|" + _extName + "文件";
            sfd.FileName = _fileName;
            sfd.ShowDialog();
            return sfd.FileName;
        }
        void sfd_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _confirm = true;
        }

        #region IDisposable 成员

        public void Dispose()
        {

        }

        #endregion
    }
}