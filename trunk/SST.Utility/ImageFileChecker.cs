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
using Silmoon;
using System.Diagnostics;

namespace SST.Utility
{
    public partial class ImageFileChecker : Form
    {
        Thread _th;
        string[] Extname = new string[] { ".jpg", ".jpeg", ".gif", ".png" };
        GBC _g;
        public ImageFileChecker(GBC g)
        {
            _g = g;
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco1;
            Show();
        }

        private void ctlBrowserButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK || Directory.Exists(fbd.SelectedPath))
            {
                ctlCheckFolderPathTextBox.Text = fbd.SelectedPath;
            }
        }

        private void ctlStartCheckButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(ctlCheckFolderPathTextBox.Text))
            {
                MessageBox.Show("无效的目录。", "war", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ctlStartCheckButton.Text == "开始(&S)")
            {
                if (ctlResultListView.Items.Count != 0)
                {
                    if (MessageBox.Show("清空列表？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        ctlResultListView.Items.Clear();
                }

                _th = new Thread(_th_checking);
                _th.IsBackground = true;
                _th.Start();
                ctlStartCheckButton.Text = "停止(&S)";
            }
            else
            {
                _th.Abort();
                ctlStartCheckButton.Text = "开始(&S)";
                label2.Text = "中止...";
            }
        }
        void _th_checking()
        {
            check(ctlCheckFolderPathTextBox.Text);
            label2.Text = "检查完毕";
            ctlStartCheckButton.Text = "开始(&S)";
        }
        void check(string path)
        {
            try
            {
                string[] fs = Directory.GetFiles(path);

                foreach (string file in fs)
                {
                    checkfile(file);
                }
            }
            catch { }

            try
            {
                string[] ds = Directory.GetDirectories(path);

                foreach (string dpath in ds)
                {
                    try
                    { check(dpath); }
                    catch { }
                }
            }
            catch { }
        }
        void checkfile(string file)
        {

            try
            {
                if (!SmString.FindFormStringArray(Extname, Path.GetExtension(file).ToLower()))
                    return;


                label2.Text = SmString.KeepStringLenght(file, 70, " ... ") + " (完成中...)";
                Image disimg = pictureBox1.Image;
                Image img = Image.FromFile(file);
                label2.Text = SmString.KeepStringLenght(file, 70, " ... ") + " (完成解码)";
                pictureBox1.Image = img;
                if (disimg != null)
                    disimg.Dispose();
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(ThreadAbortException))
                    return;

                FileStream fstream = File.Open(file, FileMode.OpenOrCreate);
                byte[] bufferByte = new byte[10240];
                int fLenght = fstream.Read(bufferByte, 0, bufferByte.Length);
                string fileContent = Encoding.Default.GetString(bufferByte);
                fstream.Close();
                fstream.Dispose();
                fstream = null;
                bufferByte = null;
                fileContent = fileContent.Trim().ToLower();

                if (fileContent.IndexOf("createobject") != -1 || fileContent.IndexOf("end if") != -1 || fileContent.IndexOf("request.") != -1)
                    ctlResultListView.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file), file, "疑似ASP木马" }));
                else if (fileContent.IndexOf("<%#@") != -1)
                    ctlResultListView.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file), file, "疑似加密ASP文件" }));
                else if (fileContent.IndexOf("@eval") != -1 || fileContent.IndexOf("$_get[") != -1 || fileContent.IndexOf("$_form[") != -1 || fileContent.IndexOf("<?php") != -1)
                    ctlResultListView.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file), file, "疑似PHP木马" }));
                else
                    ctlResultListView.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file), file, "无效图片" }));
            }
        }

        private void ImageFileChecker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_th != null) _th.Abort();
        }

        private void 记事本打开TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = ctlResultListView.SelectedItems[0].SubItems[1].Text;
            if (new FileInfo(file).Length > (512 * 1024))
            {
                if (MessageBox.Show("这个文件大于512KB，打开可能会导致记事本停止响一段时间，继续？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            Process.Start(@"c:\windows\system32\notepad.exe", file);
        }
        private void 打开文件目录DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = ctlResultListView.SelectedItems[0].SubItems[1].Text;
            Process.Start("explorer", " /select, " + file);
        }
        private void 图片查看器打开IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = ctlResultListView.SelectedItems[0].SubItems[1].Text;
            Process.Start(file, "rundll32.exe C:\\WINDOWS\\system32\\shimgvw.dll,ImageView_Fullscreen");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (ctlResultListView.SelectedItems.Count == 0)
            {
                记事本打开TToolStripMenuItem.Enabled = false;
                打开文件目录DToolStripMenuItem.Enabled = false;
                图片查看器打开IToolStripMenuItem.Enabled = false;
            }
            else
            {
                记事本打开TToolStripMenuItem.Enabled = true;
                打开文件目录DToolStripMenuItem.Enabled = true;
                图片查看器打开IToolStripMenuItem.Enabled = true;
            }
        }
    }
}