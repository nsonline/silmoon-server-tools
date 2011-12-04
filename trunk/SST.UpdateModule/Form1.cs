using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace SST.UpdateModule
{
    public partial class Form1 : Form
    {
        string[] fileList;
        IniFile iniFile = new IniFile(Application.StartupPath + "\\Config.ini");
        IniFile riniFile = new IniFile(Application.StartupPath + "\\_updateInfo.ini");
        string _rconfigURL;
        int nowFilec = 0;
        int fileCount;
        int kuai;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            _rconfigURL = iniFile.ReadInivalue("Config", "RemoteConfigURL");
            if (string.IsNullOrEmpty(_rconfigURL))
            {
                _rconfigURL = "http://client.silmoon.com/SilmoonServertools/Config.txt";
                //MessageBox.Show("丢失远程更新的配置，就是Config.ini文件中的某些参数，请下载最新版本的程序。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Close();
                //return;
            }
            WebClient _webClient = new WebClient();
            _webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(_webClient_DownloadFileCompleted);
            _webClient.DownloadFileAsync(new Uri(_rconfigURL), Application.StartupPath + "//_updateInfo.ini");
        }

        void _webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            label1.Text = "远程版本" + riniFile.ReadInivalue("Version", "AppVersion");
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
                    File.Copy(Application.StartupPath + "\\tmp\\" + Path.GetFileName(fileList[i]), Application.StartupPath + "\\" + Path.GetFileName(fileList[i]), true);
                }
                File.Delete(Application.StartupPath + "\\_updateInfo.ini");
                File.Delete(Application.StartupPath + "\\FileList.txt");

                if (File.Exists(Application.StartupPath + "\\SST.Network.dll")) File.Delete(Application.StartupPath + "\\SST.Network.dll");
                if (File.Exists(Application.StartupPath + "\\SST.Network.Resource.dll")) File.Delete(Application.StartupPath + "\\SST.Network.Resource.dll");
                if (File.Exists(Application.StartupPath + "\\SST.Ext.IIS.dll")) File.Delete(Application.StartupPath + "\\SST.Ext.IIS.dll");
                Directory.Delete(Application.StartupPath + "\\tmp\\", true);
                Control.CheckForIllegalCrossThreadCalls = false;
                label2.Text = "完成更新任务！";
                button1.Visible = true;
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\StartSST.exe");
            Application.Exit();
        }
    }
}