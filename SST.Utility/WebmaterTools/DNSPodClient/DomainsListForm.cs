using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Silmoon.Utility;
using Silmoon;
using System.Threading;
using System.Net;
using Silmoon.Windows.ControlsHelper;
using System.Diagnostics;
using System.Collections;
using System.IO;
using DNSPodClient.Adv;

namespace DNSPodClient
{
    public partial class DomainsListForm : Form
    {
        GBC _g;
        public DomainsListForm(GBC g)
        {
            _g = g;
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            
            ////this.Icon = DNSPodClient.Properties.Resources.DNSPod_1_Red;
            ctlDomainList.ListViewItemSorter = new ListViewColumnSorter();
            Show();
        }
        private void DomainListForm_Shown(object sender, EventArgs e)
        {
            ExecAsync(RefreshListView);
            ExecAsync(RefreshDNSPodState);
        }

        private void RefreshDNSPodState()
        {
            Thread.Sleep(1000);
            try
            {
                while (true)
                {

                    WebClient _wclient = new WebClient();
                    string result = _wclient.DownloadString("http://dnspod.server4.server.silmoon.com/DNSPod_Interface.ashx");
                    string[] resultArr = result.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] nsString = new string[6];
                    for (int i = 0; i < 6; i++)
                    {
                        string[] lineArr = resultArr[i].Split(new string[] { "|||" }, StringSplitOptions.None);
                        if (lineArr[2] == "Running")
                            nsString[i] = "����";
                        else if (lineArr[2] == "Stoped")
                            nsString[i] = "����Ӧ";
                        else nsString[i] = "δ֪";
                    }
                    ctltStateLabel.Text = "NS1:" + nsString[0] + ",NS2:" + nsString[1] + ",NS3:" + nsString[2] + ",NS4:" + nsString[3] + ",NS5:" + nsString[4] + ",NS6:" + nsString[5];
                    _wclient.Dispose();
                    Thread.Sleep(180000);
                }
            }
            catch (Exception ex) { ctltStateLabel.Text = "�ӿڷ���������:" + ex.Message; }
        }

        private void ctlDomainList_DoubleClick(object sender, EventArgs e)
        {
            EditDomain();
        }

        private void ˢ���б�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecAsync(RefreshListView);
        }
        private void �༭����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDomain();
        }
        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecAsync(SetDomain);
        }
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDomain();
        }
        private void ɾ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecAsync(DeleteDomain);
        }


        private void ctltEditDomainButton_Click(object sender, EventArgs e)
        {
            EditDomain();
        }
        private void ctltSetDomainButton_Click(object sender, EventArgs e)
        {
            ExecAsync(SetDomain);
        }
        private void ctltAddDomainButton_Click(object sender, EventArgs e)
        {
            AddDomain();
        }
        private void ctltDeleteDomainButton_Click(object sender, EventArgs e)
        {
            ExecAsync(DeleteDomain);
        }


        private void ctlDomainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctlDomainList.SelectedItems.Count == 0)
            {
                �༭����ToolStripMenuItem.Enabled = false;
                ɾ������ToolStripMenuItem.Enabled = false;
                ��������ToolStripMenuItem.Enabled = false;
                ctltDeleteDomainButton.Enabled = false;
                ctltEditDomainButton.Enabled = false;
                ctltSetDomainButton.Enabled = false;
            }
            else
            {
                �༭����ToolStripMenuItem.Enabled = true;
                ɾ������ToolStripMenuItem.Enabled = true;
                ��������ToolStripMenuItem.Enabled = true;
                ctltDeleteDomainButton.Enabled = true;
                ctltEditDomainButton.Enabled = true;
                ctltSetDomainButton.Enabled = true;
                if (SmString.StringToBool(ctlDomainList.SelectedItems[0].SubItems[1].Text))
                {
                    ��������ToolStripMenuItem.Text = "��������(&S)";
                    ctltSetDomainButton.Text = "��������(&S)";
                }
                else
                {
                    ��������ToolStripMenuItem.Text = "��������(&S)";
                    ctltSetDomainButton.Text = "��������(&S)";
                }
            }
        }
        void ExecAsync(ThreadStart start)
        {
            Thread _th = new Thread(start);
            _th.IsBackground = true;
            _th.Start();
        }


        void RefreshListView()
        {
            ctlStatusText.Text = "ˢ���б���";
            �༭����ToolStripMenuItem.Enabled = false;
            ɾ������ToolStripMenuItem.Enabled = false;
            ��������ToolStripMenuItem.Enabled = false;
            ctltDeleteDomainButton.Enabled = false;
            ctltEditDomainButton.Enabled = false;
            ctltSetDomainButton.Enabled = false;

            ctlDomainList.Items.Clear();
            DomainInfo[] bdiArr = _g._dnspod.GetDomains();
            ctlDomainList.BeginUpdate();
            foreach (DomainInfo info in bdiArr)
            {
                ctlDomainList.Items.Add(new ListViewItem(new string[] { info.DomainName, info.State.ToString(), info.Records.ToString(), info.ID.ToString() }));
            }
            ctlDomainList.EndUpdate();
            ctlStatusText.Text = "ˢ���б���...���";
        }
        void EditDomain()
        {
            if (ctlDomainList.SelectedItems.Count != 0)
            {
                int domainID = int.Parse(ctlDomainList.SelectedItems[0].SubItems[3].Text);
                string domain = ctlDomainList.SelectedItems[0].Text;
                RecordListForm recForm = new RecordListForm(_g, domainID, domain);
                recForm.FormClosed += new FormClosedEventHandler(recForm_FormClosed);
            }
        }
        void AddDomain()
        {
            AddDomainForm addForm = new AddDomainForm(_g);
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK) ExecAsync(RefreshListView);
        }
        void DeleteDomain()
        {
            if (MessageBox.Show(this, "���Ҫɾ����ѡ��ô��", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ctlStatusText.Text = "ɾ�����̿�ʼ��";

                bool succee = false;
                foreach (ListViewItem lv in ctlDomainList.SelectedItems)
                {
                    ctlStatusText.Text = "����" + lv.SubItems[0].Text;
                    if (_g._dnspod.RemoveDomain(int.Parse(lv.SubItems[3].Text)).DoubleStateFlag)
                        succee = true;
                }
                if (succee) RefreshListView();
                ctlStatusText.Text = "ɾ��������ϡ�";
            }
        }
        void SetDomain()
        {
            ctlStatusText.Text = "���ù��̿�ʼ��";
            bool enable = false;
            if (SmString.StringToBool(ctlDomainList.SelectedItems[0].SubItems[1].Text))
                enable = false;
            else enable = true;

            bool succee = false;
            foreach (ListViewItem lv in ctlDomainList.SelectedItems)
            {
                ctlStatusText.Text = "����" + lv.SubItems[0].Text;
                if (_g._dnspod.SetDomainState(int.Parse(lv.SubItems[3].Text), enable).DoubleStateFlag)
                    succee = true;
            }
            if (succee) RefreshListView();
            ctlStatusText.Text = "���ù�����ϡ�";
        }

        void recForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((RecordListForm)sender).isEdited) ExecAsync(RefreshListView);
        }

        private void ctlDomainList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == ((ListViewColumnSorter)ctlDomainList.ListViewItemSorter).SortColumn)
            {
                if (((ListViewColumnSorter)ctlDomainList.ListViewItemSorter).Order == SortOrder.Ascending)
                    ((ListViewColumnSorter)ctlDomainList.ListViewItemSorter).Order = SortOrder.Descending;
                else
                    ((ListViewColumnSorter)ctlDomainList.ListViewItemSorter).Order = SortOrder.Ascending;
            }
            else
            {
                ((ListViewColumnSorter)ctlDomainList.ListViewItemSorter).SortColumn = e.Column;
                ((ListViewColumnSorter)ctlDomainList.ListViewItemSorter).Order = SortOrder.Ascending;
            }
            this.ctlDomainList.Sort();
        }

        private void ����AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Other.AboutForm(_g).ShowDialog();
        }
        private void �����б�EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "���ڴ洢�����б���ı��ļ�(*.txt)|*.txt";
            sfd.FileName = _g.Username.Split(new string[] { "@" }, StringSplitOptions.None)[0] + ".txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ArrayList array = new ArrayList();
                for (int i = 0; i < ctlDomainList.Items.Count; i++)
                {
                    ListViewItem item = ctlDomainList.Items[i];
                    array.Add(item.SubItems[0].Text);
                }
                File.WriteAllLines(sfd.FileName, (string[])array.ToArray(typeof(string)));
                ctlStatusText.Text = "�����ɹ���һ��" + array.Count + "����¼";
            }
        }
        private void �˳�XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dNSPodDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.dnspod.com/?come=" + _g.ProductString);
        }
        private void �����б�IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportDomainsForm imForm = new ImportDomainsForm(_g);
            if (imForm.ShowDialog() == DialogResult.OK)
                RefreshListView();
        }
    }
}