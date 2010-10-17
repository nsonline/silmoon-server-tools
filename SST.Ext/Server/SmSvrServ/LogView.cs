using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SST.Ext.Server.SmSvrServ
{
    public partial class LogView : Form
    {
        FileSystemWatcher fsw = new FileSystemWatcher();
        GBC _g;
        public LogView(GBC g)
        {
            _g = g;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            Show();
            fsw.Path = @"c:\windows\system32\";
            fsw.Filter = "SmSvrServ.log";
            fsw.Created += new FileSystemEventHandler(fsw_Created);
            fsw.Changed += new FileSystemEventHandler(fsw_Changed);
            fsw.EnableRaisingEvents = true;
        }

        void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            FillList();
        }
        void fsw_Created(object sender, FileSystemEventArgs e)
        {
            FillList();
        }

        private void LogView_Load(object sender, EventArgs e)
        {
            FillList();
        }
        void FillList()
        {
            try
            {
                if (File.Exists(@"c:\windows\system32\SmSvrServ.log"))
                {
                    string[] logLine = File.ReadAllLines(@"c:\windows\system32\SmSvrServ.log");
                    listBox1.BeginUpdate();
                    listBox1.Items.Clear();
                    foreach (string line in logLine)
                    {
                        listBox1.Items.Insert(0, line);
                    }
                    listBox1.EndUpdate();
                }
                else listBox1.Items.Add("未找到银月服务日志文件");
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        private void RefreshLog_Click(object sender, EventArgs e)
        {
            FillList();
        }
        private void LogView_FormClosed(object sender, FormClosedEventArgs e)
        {
            fsw.Dispose();
            Dispose(true);
        }
        private void ClearLog_Click(object sender, EventArgs e)
        {
            fsw.EnableRaisingEvents = false;
            File.WriteAllText(@"c:\windows\system32\SmSvrServ.log", "");
            FillList();
            fsw.EnableRaisingEvents = true;
        }
    }
}