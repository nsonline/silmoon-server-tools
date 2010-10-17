using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Utility;
using System.Threading;
using Silmoon;
using System.Collections;
using System.IO;
using Silmoon.Windows.ControlsHelper;
using DNSPodClient.Adv;

namespace DNSPodClient
{
    public partial class RecordListForm : Form
    {
        int _domainID;
        string _domain;
        GBC _g;
        public bool isEdited = false;

        public RecordListForm(GBC g, int domainID, string domain)
        {
            _g = g;
            _domainID = domainID;
            _domain = domain;
            InitializeComponent();
            //this.Icon = DNSPodClient.Properties.Resources.DNSPod_1_Red;
            this.Text = "域名：" + domain;
            ctlRecordList.ListViewItemSorter = new ListViewColumnSorter();
            Show();
        }

        private void RecordListForm_Shown(object sender, EventArgs e)
        {
            ExecAsync(RefreshListView);
        }

        private void ctltAddRecordButton_Click(object sender, EventArgs e)
        {
            AddRecord();
        }
        private void ctltDeleteRecordButton_Click(object sender, EventArgs e)
        {
            ExecAsync(DeleteRecord);
        }
        private void ctltEditRecordButton_Click(object sender, EventArgs e)
        {
            EditRecord();
        }
        private void ctltSetRecordButton_Click(object sender, EventArgs e)
        {
            ExecAsync(SetRecord);
        }

        private void 刷新列表RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecAsync(RefreshListView);
        }
        private void 编辑记录EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRecord();
        }
        private void 添加记录AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecord();
        }
        private void 删除记录DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecAsync(DeleteRecord);
        }
        private void 禁用记录SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecAsync(SetRecord);

        }

        void ExecAsync(ThreadStart start)
        {
            Thread _th = new Thread(start);
            _th.IsBackground = true;
            _th.Start();
        }



        private void ctlRecordList_DoubleClick(object sender, EventArgs e)
        {
            if (ctlRecordList.SelectedItems.Count == 0) return;
            RecordForm recform = new RecordForm(_g, _domain, ctlRecordList.SelectedItems[0].Text, _domainID, int.Parse(ctlRecordList.SelectedItems[0].SubItems[7].Text));
            if (recform.ShowDialog() == DialogResult.OK)
                ExecAsync(RefreshListView);
        }


        private void ctlRecordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctlRecordList.SelectedItems.Count == 0)
            {
                编辑记录EToolStripMenuItem.Enabled = false;
                删除记录DToolStripMenuItem.Enabled = false;
                禁用记录SToolStripMenuItem.Enabled = false;
                ctltDeleteRecordButton.Enabled = false;
                ctleEditRecordButton.Enabled = false;
                ctltSetRecordButton.Enabled = false;
            }
            else
            {
                编辑记录EToolStripMenuItem.Enabled = true;
                删除记录DToolStripMenuItem.Enabled = true;
                禁用记录SToolStripMenuItem.Enabled = true;
                ctltDeleteRecordButton.Enabled = true;
                ctleEditRecordButton.Enabled = true;
                ctltSetRecordButton.Enabled = true;
                if (SmString.StringToBool(ctlRecordList.SelectedItems[0].SubItems[6].Text))
                {
                    禁用记录SToolStripMenuItem.Text = "禁用记录(&S)";
                    ctltSetRecordButton.Text = "禁用记录(&S)";
                }
                else
                {
                    禁用记录SToolStripMenuItem.Text = "启用记录(&S)";
                    ctltSetRecordButton.Text = "启用记录(&S)";
                }
            }

        }

        void RefreshListView()
        {
            ctlStatusText.Text = "刷新列表中...";
            编辑记录EToolStripMenuItem.Enabled = false;
            删除记录DToolStripMenuItem.Enabled = false;
            禁用记录SToolStripMenuItem.Enabled = false;
            ctltDeleteRecordButton.Enabled = false;
            ctleEditRecordButton.Enabled = false;
            ctltSetRecordButton.Enabled = false;

            RecordInfo[] records = _g._dnspod.GetRecords(_domainID);
            ctlRecordList.Items.Clear();
            if (records != null)
            {
                ctlRecordList.BeginUpdate();
                foreach (RecordInfo info in records)
                    ctlRecordList.Items.Add(new ListViewItem(new string[] { info.Subname, info.Type.ToString(), info.Isp.ToString(), info.Value, info.MXLevel.ToString(), info.TTL.ToString(), info.Enable.ToString(), info.ID.ToString() }));
                ctlRecordList.EndUpdate();
            }
            ctlStatusText.Text = "刷新列表中...完成";
        }
        void DeleteRecord()
        {

            if (MessageBox.Show(this, "真的要删除选择的纪录么？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ctlStatusText.Text = "删除过程开始。";
                bool succee = false;
                foreach (ListViewItem lv in ctlRecordList.SelectedItems)
                {
                    ctlStatusText.Text = "删除:" + lv.SubItems[0].Text + "(" + lv.SubItems[7].Text + ")";
                    if (_g._dnspod.RemoveRecord(_domainID, int.Parse(lv.SubItems[7].Text)).DoubleStateFlag)
                        succee = true;
                }
                if (succee) RefreshListView();
                ctlStatusText.Text = "删除过程完毕。";
            }
        }
        void EditRecord()
        {
            if (ctlRecordList.SelectedItems.Count == 0) return;
            RecordForm recform = new RecordForm(_g, _domain, ctlRecordList.SelectedItems[0].Text, _domainID, int.Parse(ctlRecordList.SelectedItems[0].SubItems[7].Text));
            if (recform.ShowDialog() == DialogResult.OK)
                ExecAsync(RefreshListView);
        }
        void SetRecord()
        {
            ctlStatusText.Text = "设置过程开始。";


            bool enable = false;
            if (SmString.StringToBool(ctlRecordList.SelectedItems[0].SubItems[6].Text))
                enable = false;
            else enable = true;


            bool succee = false;
            foreach (ListViewItem lv in ctlRecordList.SelectedItems)
            {
                ctlStatusText.Text = "处理：" + lv.SubItems[0].Text;
                if (_g._dnspod.SetRecordState(_domainID, int.Parse(lv.SubItems[7].Text), enable).DoubleStateFlag)
                    succee = true;
            }
            if (succee) RefreshListView();
            ctlStatusText.Text = "设置过程完毕。";
        }
        void AddRecord()
        {
            RecordForm recform = new RecordForm(_g, _domain, _domainID);
            if (recform.ShowDialog() == DialogResult.OK)
                ExecAsync(RefreshListView);
        }

        private void ctlExportRecordsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "用于存储域名纪录的文本文件(*.txt)|*.txt";
            sfd.FileName = _domain + ".txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ArrayList array = new ArrayList();
                array.Add("?RecordList|" + _domainID + "|" + _domain + "|" + _g.ReleaseVersion);
                for (int i = 0; i < ctlRecordList.Items.Count; i++)
                {
                    ListViewItem item = ctlRecordList.Items[i];
                    array.Add(item.SubItems[0].Text + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text + "\t" + item.SubItems[3].Text + "\t" + item.SubItems[4].Text + "\t" + item.SubItems[5].Text + "\t" + item.SubItems[7].Text);
                }
                File.WriteAllLines(sfd.FileName, (string[])array.ToArray(typeof(string)));
                ctlStatusText.Text = "导出成功，一共" + array.Count + "条纪录";
            }
        }
        private void ctlImportRecordsButton_Click(object sender, EventArgs e)
        {
            ImportRecordsForm imForm = new ImportRecordsForm(_g, _domain, _domainID);
            if (imForm.ShowDialog() == DialogResult.OK) RefreshListView();
        }

        private void ctlRecordList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == ((ListViewColumnSorter)ctlRecordList.ListViewItemSorter).SortColumn)
            {
                if (((ListViewColumnSorter)ctlRecordList.ListViewItemSorter).Order == SortOrder.Ascending)
                    ((ListViewColumnSorter)ctlRecordList.ListViewItemSorter).Order = SortOrder.Descending;
                else
                    ((ListViewColumnSorter)ctlRecordList.ListViewItemSorter).Order = SortOrder.Ascending;
            }
            else
            {
                ((ListViewColumnSorter)ctlRecordList.ListViewItemSorter).SortColumn = e.Column;
                ((ListViewColumnSorter)ctlRecordList.ListViewItemSorter).Order = SortOrder.Ascending;
            }
            this.ctlRecordList.Sort();
        }
    }
}