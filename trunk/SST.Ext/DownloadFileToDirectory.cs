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
                        _g.Tray.ShowBalloonTip(1000, "����", "����\r\n" + e.Message, ToolTipIcon.Error);
                    }
                }
            }
            else Dispose();
        }

        void _wclit_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                _g.LoggerObj.WriteLogLine("�ļ� " + Path.GetFileName(_fileName) + " �������..");
                _g.Tray.ShowBalloonTip(1000, "��ʾ", "�ļ� " + Path.GetFileName(_fileName) + " �������..", ToolTipIcon.Info);
            }
            else
            {
                _g.LoggerObj.WriteLogLine("�ļ� " + Path.GetFileName(_fileName) + " ���ش���..");
                _g.Tray.ShowBalloonTip(1000, "��ʾ", "�ļ� " + Path.GetFileName(_fileName) + " ���ش���..", ToolTipIcon.Error);
            }
            ((WebClient)sender).Dispose();
            Dispose();
        }

        private string SelectedPath()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileOk += new System.ComponentModel.CancelEventHandler(sfd_FileOk);
            if (_extName != "") sfd.Filter = _extName + "|" + _extName + "�ļ�";
            sfd.FileName = _fileName;
            sfd.ShowDialog();
            return sfd.FileName;
        }
        void sfd_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _confirm = true;
        }

        #region IDisposable ��Ա

        public void Dispose()
        {

        }

        #endregion
    }
}