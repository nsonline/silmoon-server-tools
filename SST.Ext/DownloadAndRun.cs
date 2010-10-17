using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;

namespace SST.Ext
{
    class DownloadAndRun:IDisposable
    {
        GBC _g;
        bool _visual = false;
        string _filename = "";
        string _uri;

        public event AsyncCompletedEventHandler OnDownloadCompleted;
        public event EventHandler OnProcessExit;
        public DownloadAndRun(GBC g, string uri, string filename, bool visual)
        {
            _g = g;
            _uri = uri;
            _visual = visual;
            _filename = filename;
        }
        public void Start()
        {
            WebClient _wclt = new WebClient();
            _wclt.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(_wclt_DownloadFileCompleted);
            _wclt.DownloadFileAsync(new Uri(_uri), _g.Pathinfo.TempDir + _filename);
        }

        void _wclt_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                ((WebClient)sender).DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(_wclt_DownloadFileCompleted);
                ((WebClient)sender).Dispose();

                if (OnDownloadCompleted != null) OnDownloadCompleted(this, e);
                OnDownloadCompleted = null;
                Process p = new Process();
                p.StartInfo.FileName = _filename;
                p.StartInfo.WorkingDirectory = _g.Pathinfo.TempDir;
                if (!_visual) p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.EnableRaisingEvents = true;
                p.Exited += new EventHandler(p_Exited);
                p.Start();
            }
        }

        void p_Exited(object sender, EventArgs e)
        {
            if (OnProcessExit != null) OnProcessExit(this, e);
            OnProcessExit = null;
            try { File.Delete(_g.Pathinfo.TempDir + _filename); }
            catch { }
            ((Process)sender).Exited -= new EventHandler(p_Exited);
            ((Process)sender).Dispose();
        }

        #region IDisposable ≥…‘±

        public void Dispose()
        {

        }

        #endregion
    }
}
