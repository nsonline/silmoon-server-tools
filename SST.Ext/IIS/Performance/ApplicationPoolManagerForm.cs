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
                MessageBox.Show("没有找到W3SVC服务，关闭！");
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
            ctlsStateText.Text = "刷新...";
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
                string intro = "普通程序池";
                listView1.Items.Add(new ListViewItem(new string[] { queryObj["ProcessID"].ToString(), queryObj["Name"].ToString(), PoolName, date, memory, "未统计", intro }));
            }
            ctlsStateText.Text = "刷新...完毕";
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                结束进程KToolStripMenuItem.Enabled = false;
            }
            else
            {
                结束进程KToolStripMenuItem.Enabled = true;
            }
        }
        private void 结束进程KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("真的要结束掉所选进程池？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Process p = Process.GetProcessById(int.Parse(listView1.SelectedItems[0].Text));
                    p.Kill();
                    RefreshListView();
                    ctlsStateText.Text = "已经该进程发送中止信号，离进程结束有延迟时间。";
                }
                catch (Exception ex) { ctlsStateText.Text = ex.Message; }
            }
        }
        private void 刷新列表RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecAsync(RefreshListView);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView1.Columns[e.Column].Text == "内存")
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
                if (MessageBox.Show("提示信息：\r\n\t要处理的进程池数量：" + listView1.SelectedItems.Count + "\r\n确定要把选定的进程池中的网站全部合并在一个进程池吗？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ApplicationPoolInputBox inputBox = new ApplicationPoolInputBox(1);
                    if (inputBox.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show(inputBox.PoolNameInfo);
                    }
                }
            }
            else MessageBox.Show("最少选择两个进程池！", "_war", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void ctltSplitPoolButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                WebSiteBaseInfo[] infos = _iisMgr.GetAppPoolWebSites(listView1.SelectedItems[0].SubItems[2].Text);
                if (MessageBox.Show("提示信息：\r\n\t要处理的进程池：" + listView1.SelectedItems[0].SubItems[2].Text + "\r\n\t包含网站数目：" + infos.Length + "\r\n\r\n确定要把每个网站设置成独立的进程池吗？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ApplicationPoolInputBox inputBox = new ApplicationPoolInputBox(0);
                    if (inputBox.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show(inputBox.PoolNameInfo);
                    }
                }
            }
            else MessageBox.Show("最少选择一个进程池！", "_war", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    class Unit
    {
        public ManagementObject ManageObject;
        public string CPUPercent;
    }
}