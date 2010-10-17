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
                MessageBox.Show("��Ч��Ŀ¼��", "war", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ctlStartCheckButton.Text == "��ʼ(&S)")
            {
                if (ctlResultListView.Items.Count != 0)
                {
                    if (MessageBox.Show("����б�", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        ctlResultListView.Items.Clear();
                }

                _th = new Thread(_th_checking);
                _th.IsBackground = true;
                _th.Start();
                ctlStartCheckButton.Text = "ֹͣ(&S)";
            }
            else
            {
                _th.Abort();
                ctlStartCheckButton.Text = "��ʼ(&S)";
                label2.Text = "��ֹ...";
            }
        }
        void _th_checking()
        {
            check(ctlCheckFolderPathTextBox.Text);
            label2.Text = "������";
            ctlStartCheckButton.Text = "��ʼ(&S)";
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


                label2.Text = SmString.KeepStringLenght(file, 70, " ... ") + " (�����...)";
                Image disimg = pictureBox1.Image;
                Image img = Image.FromFile(file);
                label2.Text = SmString.KeepStringLenght(file, 70, " ... ") + " (��ɽ���)";
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
                    ctlResultListView.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file), file, "����ASPľ��" }));
                else if (fileContent.IndexOf("<%#@") != -1)
                    ctlResultListView.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file), file, "���Ƽ���ASP�ļ�" }));
                else if (fileContent.IndexOf("@eval") != -1 || fileContent.IndexOf("$_get[") != -1 || fileContent.IndexOf("$_form[") != -1 || fileContent.IndexOf("<?php") != -1)
                    ctlResultListView.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file), file, "����PHPľ��" }));
                else
                    ctlResultListView.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file), file, "��ЧͼƬ" }));
            }
        }

        private void ImageFileChecker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_th != null) _th.Abort();
        }

        private void ���±���TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = ctlResultListView.SelectedItems[0].SubItems[1].Text;
            if (new FileInfo(file).Length > (512 * 1024))
            {
                if (MessageBox.Show("����ļ�����512KB���򿪿��ܻᵼ�¼��±�ֹͣ��һ��ʱ�䣬������", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            Process.Start(@"c:\windows\system32\notepad.exe", file);
        }
        private void ���ļ�Ŀ¼DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = ctlResultListView.SelectedItems[0].SubItems[1].Text;
            Process.Start("explorer", " /select, " + file);
        }
        private void ͼƬ�鿴����IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = ctlResultListView.SelectedItems[0].SubItems[1].Text;
            Process.Start(file, "rundll32.exe C:\\WINDOWS\\system32\\shimgvw.dll,ImageView_Fullscreen");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (ctlResultListView.SelectedItems.Count == 0)
            {
                ���±���TToolStripMenuItem.Enabled = false;
                ���ļ�Ŀ¼DToolStripMenuItem.Enabled = false;
                ͼƬ�鿴����IToolStripMenuItem.Enabled = false;
            }
            else
            {
                ���±���TToolStripMenuItem.Enabled = true;
                ���ļ�Ŀ¼DToolStripMenuItem.Enabled = true;
                ͼƬ�鿴����IToolStripMenuItem.Enabled = true;
            }
        }
    }
}