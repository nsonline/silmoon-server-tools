using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Silmoon;
using Silmoon.Security;
using System.Threading;
using System.Collections;
using System.Diagnostics;

namespace SST.Ext.Tools
{
    public partial class ScanCode : Form
    {
        ArrayList files = new ArrayList();
        ArrayList directorys = new ArrayList();
        string[] code;
        Thread _th;
        GBC _g;
        ScanOption _scanOption = new ScanOption();

        bool analysing = false;

        public ScanCode(GBC g)
        {
            _g = g;
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _th = new Thread(_th_proc_scan);
            this.Icon = SST.Resource.Resource.SSTIco2;
            Show();
        }

        private void ctlSelectDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath != "")
            {
                ctlDirectoryTextBox.Text = fbd.SelectedPath;
                ctlAnalysebutton.Enabled = true;
                ctlStart.Enabled = false;
            }
        }

        private void ctlAnalysebutton_Click(object sender, EventArgs e)
        {
            if (ctlAnalysebutton.Text == "�����ݹ�")
            {
                analysing = true;
                _th = new Thread(_th_proc_analyse);
                _th.IsBackground = true;
                _th.Start();
            }
            else
                analysing = false;
        }
        private void ctlLoadCodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "���´�����(*.SmCodeBox)|*.smcodebox|�����ļ�(*.*)|*.*";
                ofd.FileName = Application.StartupPath + "\\" + "CodeBox.SmCodeBox";
                ofd.ShowDialog();
                if (ofd.FileName != "")
                {
                    if (File.Exists(ofd.FileName))
                    {
                        string[] codeFile = File.ReadAllLines(ofd.FileName);
                        ArrayList codeArr = new ArrayList();
                        foreach (string s in codeFile)
                        {
                            codeArr.Add(EncryptString.DiscryptSilmoonBinary(s));
                        }
                        code = (string[])codeArr.ToArray(typeof(string));

                        ctlStart.Enabled = true;
                    }
                }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        private void ctlOptionsButton_Click(object sender, EventArgs e)
        {
            ScanCodeOptionWindow optionWindow = new ScanCodeOptionWindow(_g, _scanOption);
            optionWindow.ShowDialog();
        }

        private void ctlStart_Click(object sender, EventArgs e)
        {

            if (_th.ThreadState != System.Threading.ThreadState.Background && _th.ThreadState != System.Threading.ThreadState.Unstarted)
                _th = new Thread(_th_proc_scan);
            if (ctlStart.Text == "ɨ��(&S)")
            {
                if (ctlResultFileListView.Items.Count != 0)
                {
                    if (MessageBox.Show("����б�", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        ctlResultFileListView.Items.Clear();
                }
                _th.IsBackground = true;
                _th.Start();
            }
            else
            {
                _th.Abort();
                ctl_status_Text.Text = "�û���ֹ��";
                ctlProcessFileLabel.Text = "�û���ֹ��";
                _StopScan();
            }
        }
        void _th_proc_scan()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            try
            {
                _StartScan();
                string[] extNames = ctlExtNameTextBox.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                int totalFile = files.Count;
                int scanFileIndex = 0;
                long sizeB = _scanOption.FileMaxSizeKB * 1024;
                bool checkSize = true;
                if (_scanOption.FileMaxSizeKB == 0) checkSize = false;

                foreach (string file in files)
                {
                    scanFileIndex++;
                    int persent = (int)(((double)scanFileIndex / (double)totalFile) * 100);
                    ctl_status_Text.Text = "���� " + persent + "%...";
                    ctl_status_process.Value = persent;
                    ctlCountFileLabel.Text = scanFileIndex + "/" + totalFile;

                    try
                    {
                        if (SmString.FindFormStringArray(extNames, Path.GetExtension(file).Replace(".", "")))
                        {
                            if (checkSize)
                            {
                                if (new FileInfo(file).Length > sizeB)
                                {
                                    write("(����2)" + file);
                                    continue;
                                }
                            }
                            write("(ɨ��0)" + file);
                            string fileContent = File.ReadAllText(file).ToLower();
                            foreach (string scode in code)
                            {
                                string[] vLineArr = scode.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                                if (fileContent.IndexOf(vLineArr[0].ToLower()) != -1)
                                {
                                    writevir(vLineArr[1], "0", file);
                                }
                            }
                        }
                        else
                        { write("(����1)" + file); }
                    }
                    catch (Exception ex)
                    {
                        if (ex.GetType() != typeof(ThreadAbortException))
                            write("(����3)" + file);
                    }
                }
                ctl_status_Text.Text = "ɨ�����";
                ctlProcessFileLabel.Text = "ɨ�����...";
            }
            catch (Exception ex)
            { if (ex.GetType() != typeof(ThreadAbortException)) _g.ProtectRunAsClass(ex.ToString()); }
            ctlStart.Enabled = false;
            Thread.Sleep(2000);
            _StopScan();
        }
        void _th_proc_analyse()
        {
            try
            {
                ctlResultFileListView.Items.Clear();
                ctlAnalysebutton.Text = "ֹͣ";

                files.Clear();
                directorys.Clear();
                GetFiles(ctlDirectoryTextBox.Text);
                ctlAnalyseStatusLabel.Text = files.Count + "���ļ���";
                ctlAnalyseStatusLabel.Text += directorys.Count + "��Ŀ¼";

                if (analysing)
                    ctl_status_Text.Text = "�������...";
                else
                {
                    ctl_status_Text.Text = "������ֹ...";
                    ctlAnalyseStatusLabel.Text += "(δ������ϵ�����)";
                }


                ctlAnalysebutton.Text = "�����ݹ�";
                if (ctlLoadCodeButton.Enabled)
                { ctlStart.Enabled = true; }
                else { ctlLoadCodeButton.Enabled = true; }

            }
            catch (Exception ex)
            {
                MessageBox.Show("�����������뱣֤����ָ����Ŀ¼�����ļ����ж�ȡȨ�ޣ�\r\n\r\n    " + ex.Message, "_msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctlAnalysebutton.Text = "�����ݹ�";
                ctlAnalysebutton.Enabled = true;
            }
        }

        void GetFiles(string path)
        {
            if (!analysing) return;
            try
            {
                string[] fs = Directory.GetFiles(path);

                foreach (string file in fs)
                    files.Add(file);
            }
            catch { }

            try
            {
                string[] ds = Directory.GetDirectories(path);

                foreach (string dpath in ds)
                {
                    directorys.Add(dpath);
                    ctl_status_Text.Text = "���Ŀ¼:" + SmString.KeepStringLenght(dpath, 80, " ... ");
                    try
                    { GetFiles(dpath); }
                    catch { }
                }
            }
            catch { }
        }
        void write(string s)
        {
            ctlProcessFileLabel.Text = SmString.KeepStringLenght(s, 80, " ... ");
        }
        void writevir(string codeName, string codeLevel, string path)
        {
            ctlResultFileListView.Items.Add(new ListViewItem(new string[] { codeName, codeLevel, path }));
        }

        void _StartScan()
        {
            ctlOptionsButton.Enabled = false;
            ctlSelectDirectoryButton.Enabled = false;
            ctlAnalysebutton.Enabled = false;
            ctlLoadCodeButton.Enabled = false;
            ctl_status_process.Visible = true;
            ctlStart.Text = "ֹͣ(&S)";
        }
        void _StopScan()
        {
            ctlOptionsButton.Enabled = true;
            ctlSelectDirectoryButton.Enabled = true;
            ctlAnalysebutton.Enabled = true;
            ctlLoadCodeButton.Enabled = true;

            ctl_status_process.Visible = false;
            ctl_status_process.Value = 0;
            ctlStart.Enabled = true;
            ctlStart.Text = "ɨ��(&S)";
        }


        #region �������ҳ
        private void ctlOpenCodeBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "���´�����(*.SmCodeBox)|*.smcodebox|�����ļ�(*.*)|*.*";
                ofd.FileName = Application.StartupPath + "\\" + "CodeBox.SmCodeBox";
                ofd.ShowDialog();
                if (ofd.FileName != "")
                {
                    Read(ofd.FileName);
                }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctl2CodeBoxListView.SelectedItems.Count != 0)
            {
                ctl2CodeTypeTextBox.Text = ctl2CodeBoxListView.SelectedItems[0].Text;
                ctl2CodeTextBox.Text = ctl2CodeBoxListView.SelectedItems[0].SubItems[1].Text;
            }
        }
        private void ctlWriteCodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctl2CodeBoxListView.SelectedItems.Count != 0)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { ctl2CodeTypeTextBox.Text, ctl2CodeTextBox.Text });
                    lvi.BackColor = Color.GreenYellow;
                    ctl2CodeBoxListView.Items[ctl2CodeBoxListView.Items.IndexOf(ctl2CodeBoxListView.FocusedItem)] = lvi;
                }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        void Save()
        {
            ArrayList _array = new ArrayList();
            foreach (ListViewItem items in ctl2CodeBoxListView.Items)
            {
                string uncryLine = items.SubItems[1].Text + "|" + items.Text;
                _array.Add(EncryptString.EncryptSilmoonBinary(uncryLine));
            }
            File.WriteAllLines(ctl2FilePathLabel.Text, ((string[])_array.ToArray(typeof(string))));
            MessageBox.Show("���´�����ļ��ɹ����棡", "_s", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void Read(string file)
        {
            if (File.Exists(file))
            {
                ctl2FilePathLabel.Text = file;
                string[] fileLine = File.ReadAllLines(file);
                ctl2CodeBoxListView.Items.Clear();
                foreach (string line in fileLine)
                {
                    string sline = EncryptString.DiscryptSilmoonBinary(line);
                    string[] lineArr = sline.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                    ctl2CodeBoxListView.Items.Add(new ListViewItem(new string[] { lineArr[1], lineArr[0] }));
                }
                ctl2SaveButton.Enabled = true;
                ctl2WriteCodeButton.Enabled = true;
            }
        }
        private void ctlSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                Read(ctl2FilePathLabel.Text);
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        private void ���AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "" });
            lvi.BackColor = Color.Red;
            ctl2CodeBoxListView.Items.Add(lvi);
        }
        private void ɾ��RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ctl2CodeBoxListView.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("��ȷ��ɾ�����������¼��", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    ctl2CodeBoxListView.Items.Remove(ctl2CodeBoxListView.SelectedItems[0]);
            }
        }
        #endregion

        private void ctlResultListViewMenu_Opening(object sender, CancelEventArgs e)
        {
            if (ctlResultFileListView.SelectedItems.Count == 0)
            {
                ���±���TToolStripMenuItem.Enabled = false;
                ���ļ�Ŀ¼DToolStripMenuItem.Enabled = false;
            }
            else
            {
                ���±���TToolStripMenuItem.Enabled = true;
                ���ļ�Ŀ¼DToolStripMenuItem.Enabled = true;
            }
        }
        private void ���±���TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = ctlResultFileListView.SelectedItems[0].SubItems[2].Text;
            if (new FileInfo(file).Length > (512 * 1024))
            {
                if (MessageBox.Show("����ļ�����512KB���򿪿��ܻᵼ�¼��±�ֹͣ��һ��ʱ�䣬������", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            Process.Start(@"c:\windows\system32\notepad.exe", file);
        }
        private void ���ļ�Ŀ¼DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = ctlResultFileListView.SelectedItems[0].SubItems[2].Text;
            Process.Start("explorer", " /select, " + file);
        }
        private void ScanCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_th != null)
                _th.Abort();
            _th = null;
            files.Clear();
            directorys.Clear();

        }
    }
    public class ScanOption
    {

        public long _fileMaxSizeKB = 512;
        public long FileMaxSizeKB
        {
            get { return _fileMaxSizeKB; }
            set
            {
                if (value < 0) throw new ArgumentException("����ֵ̫С����Ӧ��С��1��", "FileMaxSizeKB");
                if (value > 51200) throw new ArgumentException("����ֵ̫�󣬲�Ӧ�ô���51200��", "FileMaxSizeKB");
                _fileMaxSizeKB = value;

            }
        }
    }
}