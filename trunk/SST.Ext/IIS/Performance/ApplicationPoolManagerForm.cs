using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Collections;
using System.Diagnostics;
using Silmoon.Windows.ControlsHelper;
using System.Threading;
using Silmoon.Windows.Server.IIS;

namespace SST.Ext.IIS.Performance
{
    public partial class ApplicationPoolManagerForm : Form
    {
        ManagementObjectSearcher searcher;
        ArrayList array = new ArrayList();
        IISManager _iisMgr = new IISManager();

        public ApplicationPoolManagerForm()
        {
            if (!Silmoon.Service.ServiceControl.IsExisted("W3SVC"))
            {
                MessageBox.Show("û���ҵ�W3SVC���񣬹رգ�");
                Close();
                return;
            }
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            listView1.ListViewItemSorter = new ListViewColumnSorter();
            Show();
        }
        public void ExecAsync(ThreadStart start)
        {
            Thread _th = new Thread(start);
            _th.IsBackground = true;
            _th.Start();
        }

        private void ApplicationPoolsForm_Shown(object sender, EventArgs e)
        {
            ExecAsync(RefreshListView);
        }

        private void RefreshListView()
        {
            ctlsStateText.Text = "ˢ��...";
            searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Process where Name = 'w3wp.exe'");
            array.Clear();
            foreach (ManagementObject queryObj in searcher.Get())
            {
                Unit unit = new Unit();
                unit.ManageObject = queryObj;
                unit.CPUPercent = "0%";
                array.Add(unit);
            }
            FillListView();
        }
        private void FillListView()
        {
            listView1.Items.Clear();
            foreach (Unit unit in array)
            {
                ManagementObject queryObj = unit.ManageObject;
                string PoolName = queryObj["CommandLine"].ToString().Split(new string[] { "-ap \"" }, StringSplitOptions.None)[1].Replace("\"", "");
                string date = queryObj["CreationDate"].ToString();
                date = date.Substring(0, 4) + "-" + date.Substring(4, 2) + "-" + date.Substring(6, 2) + " " + date.Substring(8, 2) + ":" + date.Substring(10, 2) + ":" + date.Substring(12, 2);
                string memory = ((int)(int.Parse(queryObj["WorkingSetSize"].ToString()) / 1048576)).ToString() + "MB";
                string intro = "��ͨ�����";
                listView1.Items.Add(new ListViewItem(new string[] { queryObj["ProcessID"].ToString(), queryObj["Name"].ToString(), PoolName, date, memory, "δͳ��", intro }));
            }
            ctlsStateText.Text = "ˢ��...���";
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                ��������KToolStripMenuItem.Enabled = false;
            }
            else
            {
                ��������KToolStripMenuItem.Enabled = true;
            }
        }
        private void ��������KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("���Ҫ��������ѡ���̳أ�", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Process p = Process.GetProcessById(int.Parse(listView1.SelectedItems[0].Text));
                    p.Kill();
                    RefreshListView();
                    ctlsStateText.Text = "�Ѿ��ý��̷�����ֹ�źţ�����̽������ӳ�ʱ�䡣";
                }
                catch (Exception ex) { ctlsStateText.Text = ex.Message; }
            }
        }
        private void ˢ���б�RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecAsync(RefreshListView);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView1.Columns[e.Column].Text == "�ڴ�")
                ((ListViewColumnSorter)listView1.ListViewItemSorter).ReplaceString = "MB";
            else
                ((ListViewColumnSorter)listView1.ListViewItemSorter).ReplaceString = "";
            if (e.Column == ((ListViewColumnSorter)listView1.ListViewItemSorter).SortColumn)
            {
                if (((ListViewColumnSorter)listView1.ListViewItemSorter).Order == SortOrder.Ascending)
                    ((ListViewColumnSorter)listView1.ListViewItemSorter).Order = SortOrder.Descending;
                else
                    ((ListViewColumnSorter)listView1.ListViewItemSorter).Order = SortOrder.Ascending;
            }
            else
            {
                ((ListViewColumnSorter)listView1.ListViewItemSorter).SortColumn = e.Column;
                ((ListViewColumnSorter)listView1.ListViewItemSorter).Order = SortOrder.Ascending;
            }
            this.listView1.Sort();
        }

        private void ctltRefreshListButton_Click(object sender, EventArgs e)
        {
            ExecAsync(RefreshListView);
        }

        private void ctltMergePoolButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 1)
            {
                WebSiteBaseInfo[] infos = _iisMgr.GetAppPoolWebSites(listView1.SelectedItems[0].SubItems[2].Text);
                if (MessageBox.Show("��ʾ��Ϣ��\r\n\tҪ����Ľ��̳�������" + listView1.SelectedItems.Count + "\r\nȷ��Ҫ��ѡ���Ľ��̳��е���վȫ���ϲ���һ�����̳���", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ApplicationPoolInputBox inputBox = new ApplicationPoolInputBox(1);
                    if (inputBox.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show(inputBox.PoolNameInfo);
                    }
                }
            }
            else MessageBox.Show("����ѡ���������̳أ�", "_war", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void ctltSplitPoolButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                WebSiteBaseInfo[] infos = _iisMgr.GetAppPoolWebSites(listView1.SelectedItems[0].SubItems[2].Text);
                if (MessageBox.Show("��ʾ��Ϣ��\r\n\tҪ����Ľ��̳أ�" + listView1.SelectedItems[0].SubItems[2].Text + "\r\n\t������վ��Ŀ��" + infos.Length + "\r\n\r\nȷ��Ҫ��ÿ����վ���óɶ����Ľ��̳���", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ApplicationPoolInputBox inputBox = new ApplicationPoolInputBox(0);
                    if (inputBox.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show(inputBox.PoolNameInfo);
                    }
                }
            }
            else MessageBox.Show("����ѡ��һ�����̳أ�", "_war", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    class Unit
    {
        public ManagementObject ManageObject;
        public string CPUPercent;
    }
}