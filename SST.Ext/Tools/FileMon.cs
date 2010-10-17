using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using Silmoon.IO;

namespace SST.Ext.Tools
{
    public partial class FileMon : Form
    {
        GBC _g;
        FileWatcher _watcher;
        bool _scrRunning = false;

        public FileMon()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.Icon = SST.Resource.Resource.SSTIco;
        }
        public void Show(GBC g)
        {
            _g = g;
            _scrRunning = _g.FileWatch.Running;
            _watcher = _g.FileWatch;

            _watcher.OnStart += new Silmoon.CancleEventHander(_watcher_OnStart);
            _watcher.OnStop += new Silmoon.CancleEventHander(_watcher_OnStop);
            _watcher.FileEvent += new FileEventHander(_watcher_FileEvent);
            Show();
        }

        void _watcher_OnStop(object sender, bool cancle)
        {
            button1.Text = "开始(&S)";
            this.Text = "文件事件监控";
        }
        void _watcher_OnStart(object sender, bool cancle)
        {
            button1.Text = "停止(&S)";
            this.Text = "文件事件监控 Running";
        }


        void fsw_Renamed(object sender, RenamedEventArgs e)
        {
            writeToConsole("重名:" + e.FullPath);
            writeToConsole("     (源文件名为:" + e.OldFullPath + ")");
        }
        void _watcher_FileEvent(object sender, FileEventArgs e)
        {
            string showString = "";
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Changed:
                    showString = "编辑";
                    break;
                case WatcherChangeTypes.Created:
                    showString = "创建";
                    break;
                case WatcherChangeTypes.Deleted:
                    showString = "删除";
                    break;
                case WatcherChangeTypes.Renamed:
                    showString = "重命名";
                    break;
                default:
                    break;
            }
            if (e.ChangeType != WatcherChangeTypes.Renamed)
                writeToConsole(showString + ":" + e.FullPath);
            else
            {
                writeToConsole("重名:" + e.RenameName.FullPath);
                writeToConsole("     (源文件名为:" + e.RenameName.OldFullPath + ")");
            }
        }

        void writeToConsole(string s)
        {
            if (!VisSysFileCheckBox.Checked)
            {
                if (s.ToLower().IndexOf("ntuser.dat.log") != -1) { return; }
                if (s.ToLower().IndexOf("system32\\config\\software.log") != -1) { return; }
            }
            listBox1.Items.Add(s);
            if (AutoRollCheckBox.Checked)
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "开始(&S)")
                _watcher.Start();
            else
                _watcher.Stop();
        }

        private void SmFileMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_scrRunning) _g.FileWatch.Stop();
            _watcher.OnStart -= new Silmoon.CancleEventHander(_watcher_OnStart);
            _watcher.OnStop -= new Silmoon.CancleEventHander(_watcher_OnStop);
            _watcher.FileEvent -= new FileEventHander(_watcher_FileEvent);
            Dispose(true);
        }
        private void FormTopCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = FormTopCheck.Checked;
        }

        private void FileMon_Load(object sender, EventArgs e)
        {
            if (_g.FileWatch.Running) { button1.Text = "停止(&S)"; }
        }

        private void 复制路径FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                Clipboard.SetDataObject(listBox1.SelectedItem.ToString().Substring(3, listBox1.SelectedItem.ToString().Length - 3));
        }
        private void 复制行LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                Clipboard.SetDataObject(listBox1.SelectedItem.ToString());
        }

        private void FileMon_Resize(object sender, EventArgs e)
        {
            listBox1.Height = 412 + (this.Height - 481);
            panel1.Location = new Point(259 + (this.Width - 635), 418 + (this.Height - 481));
        }
    }
}