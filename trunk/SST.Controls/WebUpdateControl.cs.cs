using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Net;
using System.Threading;
using System.Runtime.InteropServices;

namespace SST.Controls
{
    [
ComVisible(true),
Guid("99994578-81ea-4850-9911-13ba2d71000c"),
]

    public partial class WebUpdateControl : UserControl
    {
        string[] fileList;
        int nowFilec = 0;
        int fileCount;
        int kuai;

        public WebUpdateControl()
        {
            InitializeComponent();
        }

        private void WebUpdateControl_Load(object sender, EventArgs e)
        {
            RegistryKey k = Registry.CurrentUser.OpenSubKey("Software\\SST");
            AppPath.Text = Path.GetDirectoryName(k.GetValue("AppPath").ToString());
            k.Close();
            button1.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            WebClient _webClient2 = new WebClient();
            _webClient2.DownloadFileCompleted += new AsyncCompletedEventHandler(_webClient2_DownloadFileCompleted);
            _webClient2.DownloadFileAsync(new Uri("http://client.silmoon.com/SilmoonServertools/FileList.txt"), Application.StartupPath + "\\FileList.txt");
        }
        void _webClient2_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            fileList = File.ReadAllLines(Application.StartupPath + "\\FileList.txt");
            try { File.Delete(Application.StartupPath + "\\FileList.txt"); }
            catch { }
            Thread _upTh = new Thread(UpdateFileInit);
            _upTh.IsBackground = true;
            _upTh.Start();
        }

        WebClient _w = new WebClient();
        private void UpdateFileInit()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            if (Directory.Exists(Application.StartupPath + "\\tmp")) Directory.Delete(Application.StartupPath + "\\tmp", true);
            Directory.CreateDirectory(Application.StartupPath + "\\tmp");

            _w.DownloadFileCompleted += new AsyncCompletedEventHandler(_w_DownloadFileCompleted);
            _w.DownloadProgressChanged += new DownloadProgressChangedEventHandler(_w_DownloadProgressChanged);

            fileCount = fileList.Length;
            kuai = 100 / fileCount;
            StartUpdateFile();
        }
        void StartUpdateFile()
        {
            label2.Text = "升级文件:" + fileList[nowFilec];
            _w.DownloadFileAsync(new Uri(fileList[nowFilec]), Application.StartupPath + "\\tmp\\" + Path.GetFileName(fileList[nowFilec]));
            MainProcBar.Value = (int)kuai * (nowFilec + 1);
            nowFilec++;
        }

        void _w_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            NowProcBar.Value = e.ProgressPercentage;
        }
        void _w_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (nowFilec < fileCount) StartUpdateFile();
            else
            {
                MainProcBar.Value = 100;
                label2.Text = "文件下载完成！";
                Thread.Sleep(1000);
                Copy();
            }
        }
        private void Copy()
        {
            label2.Text = "开始更新文件！";
            try
            {
                for (int i = 0; i < fileCount; i++)
                {
                    label2.Text = "复制:" + Path.GetFileName(fileList[i]);
                    File.Copy(Application.StartupPath + "\\tmp\\" + Path.GetFileName(fileList[i]), AppPath.Text + "\\" + Path.GetFileName(fileList[i]), true);
                    Thread.Sleep(100);
                }
                File.Delete(Application.StartupPath + "\\_updateInfo.ini");
                File.Delete(Application.StartupPath + "\\FileList.txt");
                Directory.Delete(Application.StartupPath + "\\tmp\\", true);
                Control.CheckForIllegalCrossThreadCalls = false;
                button1.Visible = true;
                label2.Text = "完成更新任务！";
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppPath.Text + "\\StartSST.exe");
        }

    }
}
