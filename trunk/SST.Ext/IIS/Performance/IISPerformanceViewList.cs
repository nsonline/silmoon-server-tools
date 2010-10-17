using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using Silmoon.Windows.Server.IIS;
using System.Diagnostics;
using Silmoon.Windows.ControlsHelper;

namespace SST.Ext.IIS.Performance
{
    public partial class IISPerformanceViewList : Form
    {
        GBC _g;
        ArrayList _perfArray = new ArrayList();
        IISManager _iisMgr = new IISManager();
        System.Timers.Timer _timer = new System.Timers.Timer();
        System.Windows.Forms.Timer _timerZ = new System.Windows.Forms.Timer();

        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();


        public IISPerformanceViewList(GBC g)
        {
            if (!Silmoon.Service.ServiceControl.IsExisted("W3SVC"))
            {
                MessageBox.Show("没有找到W3SVC服务，关闭！");
                Close();
                return;
            }
            _g = g;
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(_timer_Elapsed);
            _timer.Interval = 1000;
            _timerZ.Tick += new EventHandler(_timerZ_Tick);
            _timerZ.Interval = 1000;
            this.listView1.ListViewItemSorter = lvwColumnSorter;
            Icon = SST.Resource.Resource.SSTIco1;
            Show();
        }

        void _timerZ_Tick(object sender, EventArgs e)
        {
            FillListView();
        }
        void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                for (int i = 0; i < _perfArray.Count; i++)
                {
                    CounterUnit cu = (CounterUnit)_perfArray[i];
                    try
                    {
                        cu.TotalTransfered = uLongToTextMb(cu.pTotalTransfered.NextValue());
                        cu.TotalSent = uLongToTextMb(cu.pTotalSent.NextValue());
                        cu.TotalReceived = uLongToTextMb(cu.pTotalReceived.NextValue());
                        cu.CurrentConnections = cu.pCurrentConnections.NextValue().ToString();
                        cu.BytesTotalsec = uLongToTextMb(cu.pBytesTotalsec.NextValue());
                        cu.ISAPIExtensionRequestssec = cu.pISAPIExtensionRequestssec.NextValue().ToString();
                    }
                    catch
                    {
                        cu.TotalTransfered = "(0)异常";
                        cu.TotalSent = "(0)异常";
                        cu.TotalReceived = "(0)异常";
                        cu.CurrentConnections = "(0)异常";
                        cu.BytesTotalsec = "(0)异常";
                        cu.ISAPIExtensionRequestssec = "(0)异常";
                    }
                }
                listView1.RedrawItems(0, listView1.VirtualListSize - 1, false);
            }
            catch (Exception ex) { ctlStatusText.Text = "错误:" + ex.Message; }
        }

        private void PerformanceViewList_Shown(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            Thread _th = new Thread(_th_proc_refreshList);
            _th.IsBackground = true;
            _timer.Stop();
            _th.Start();
        }
        void _th_proc_refreshList()
        {
            try
            {
                ctlStatusText.Text = "获取网站列表...";
                WebSiteBaseInfo[] binfoArr = _iisMgr.WebSiteList;
                _perfArray.Clear();
                listView1.VirtualListSize = 0;
                foreach (WebSiteBaseInfo b in binfoArr)
                {
                    try
                    {
                        ctlStatusText.Text = "加载(" + b.SiteName + ")的性能计数器";
                        CounterUnit cu = new CounterUnit();
                        cu.SiteName = b.SiteName;

                        cu.pTotalTransfered = new PerformanceCounter("Web Service", "Total Bytes Transfered", b.SiteName);
                        cu.pTotalSent = new PerformanceCounter("Web Service", "Total Bytes Sent", b.SiteName);
                        cu.pTotalReceived = new PerformanceCounter("Web Service", "Total Bytes Received", b.SiteName);
                        cu.pCurrentConnections = new PerformanceCounter("Web Service", "Current Connections", b.SiteName);
                        cu.pBytesTotalsec = new PerformanceCounter("Web Service", "Bytes Total/sec", b.SiteName);
                        cu.pISAPIExtensionRequestssec = new PerformanceCounter("Web Service", "ISAPI Extension Requests/sec", b.SiteName);

                        cu.TotalTransfered = "NULL";
                        cu.TotalSent = "NULL";
                        cu.TotalReceived = "NULL";
                        cu.CurrentConnections = "NULL";
                        cu.BytesTotalsec = "NULL";
                        cu.ISAPIExtensionRequestssec = "NULL";

                        _perfArray.Add(cu);
                    }
                    catch
                    {
                        MessageBox.Show(this, "加载站点(" + b.SiteName + ")的性能计数器失败，可能有同样名称的网站存在，如真有的话不能加载同名的网站！", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ctlStatusText.Text = "完成加载";
                listView1.VirtualListSize = _perfArray.Count;
                _timer.Start();
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        void FillListView()
        {

            int selectIndex = -1;
            if (listView1.SelectedItems.Count != 0)
                selectIndex = listView1.SelectedIndices[0];

            listView1.BeginUpdate();
            listView1.Items.Clear();
            for (int i = 0; i < _perfArray.Count; i++)
            {
                CounterUnit cu = (CounterUnit)_perfArray[i];
                listView1.Items.Add(new ListViewItem(new string[] { cu.SiteName, toUlong(cu.pTotalTransfered.NextValue()), toUlong(cu.pTotalSent.NextValue()), toUlong(cu.pTotalReceived.NextValue()), toUlong(cu.pCurrentConnections.NextValue()), toUlong(cu.pBytesTotalsec.NextValue()) + "/s", toUlong(cu.pISAPIExtensionRequestssec.NextValue()) + "/s" }));
            }
            if (selectIndex != -1)
                if (listView1.Items.Count > selectIndex)
                    listView1.Items[selectIndex].Selected = true;

            listView1.EndUpdate();
        }
        string toUlong(float f)
        {
            return ((ulong)f).ToString();
        }


        string uLongToTextMb(float f)
        {
            ulong i = (ulong)f;
            ulong KB = ((ulong)(i / 1024));
            if (KB < 1048576)
                return KB + " Kb";
            else if (KB < 1073741824)
                return ((float)(KB / 1024)) + " Mb";
            else
                return ((float)(KB / 1048576)) + " Gb";
        }
        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex > _perfArray.Count - 1)
                e.Item = new ListViewItem(new string[] { "", "", "", "", "", "", "" });
            else
            {
                CounterUnit cu = (CounterUnit)_perfArray[e.ItemIndex];
                e.Item = new ListViewItem(new string[] { cu.SiteName, cu.TotalTransfered, cu.TotalSent, cu.TotalReceived, cu.CurrentConnections, cu.BytesTotalsec + "/s", cu.ISAPIExtensionRequestssec + "/s" });
            }
        }
        class CounterUnit
        {
            public string SiteName;
            public PerformanceCounter pTotalTransfered;
            public PerformanceCounter pTotalSent;
            public PerformanceCounter pTotalReceived;
            public PerformanceCounter pCurrentConnections;
            public PerformanceCounter pBytesTotalsec;
            public PerformanceCounter pISAPIExtensionRequestssec;


            public string TotalTransfered;
            public string TotalSent;
            public string TotalReceived;
            public string CurrentConnections;
            public string BytesTotalsec;
            public string ISAPIExtensionRequestssec;
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (!listView1.VirtualMode)
            {
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    if (lvwColumnSorter.Order == SortOrder.Ascending)
                        lvwColumnSorter.Order = SortOrder.Descending;
                    else
                        lvwColumnSorter.Order = SortOrder.Ascending;
                }
                else
                {
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
                this.listView1.Sort();
            }
            else
                MessageBox.Show(this, "在有自动刷新的虚拟集合中无法对项进行排序", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ctltStopAutoRefreshButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            { listView1.Items[i].Selected = false; }

            if (ctltStopAutoRefreshButton.Text == "启用排序")
            {
                ctltStopAutoRefreshButton.Text = "禁用排序";
                _timer.Stop();

                listView1.Items.Clear();
                listView1.VirtualMode = false;
                _timerZ.Start();
                FillListView();
            }
            else
            {
                ctltStopAutoRefreshButton.Text = "启用排序";
                _timerZ.Stop();

                listView1.Items.Clear();
                listView1.VirtualMode = true;
                _timer.Start();
            }
        }

        private void IISPerformanceViewList_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
            _timerZ.Stop();
            _timerZ.Dispose();
            foreach (CounterUnit cu in _perfArray)
            {
                cu.pBytesTotalsec.Dispose();
                cu.pCurrentConnections.Dispose();
                cu.pISAPIExtensionRequestssec.Dispose();
                cu.pTotalReceived.Dispose();
                cu.pTotalSent.Dispose();
                cu.pTotalTransfered.Dispose();
            }
        }
    }
}