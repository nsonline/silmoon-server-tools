using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections;
using Silmoon;
using Silmoon.Windows.ControlsHelper;

namespace SST.Utility.WindowsFirewall
{
    public partial class WindowsFirewallUtility : Form
    {
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        private ListViewColumnSorter lvwColumnSorter1 = new ListViewColumnSorter();
        GBC _g;
        int rdpPort = 0;
        private int RdpPort
        {
            get
            {
                if (rdpPort == 0)
                {
                    RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp");
                    rdpPort = int.Parse(k.GetValue("PortNumber").ToString());
                    k.Close();
                }
                return rdpPort;
            }
        }

        public WindowsFirewallUtility(GBC g)
        {
            InitializeComponent();
            _g = g;
            this.listView1.ListViewItemSorter = lvwColumnSorter;
            this.listView2.ListViewItemSorter = lvwColumnSorter1;
            Show();
        }

        private void P1_LoadList_Click(object sender, EventArgs e)
        {
            RegistryKey k0 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile", true);
            if (!SmString.FindFormStringArray(k0.GetSubKeyNames(), "GloballyOpenPorts")) k0.CreateSubKey("GloballyOpenPorts");
            k0.Close();

            RegistryKey k1 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\GloballyOpenPorts", true);
            if (!SmString.FindFormStringArray(k1.GetSubKeyNames(), "List")) k1.CreateSubKey("List");
            k1.Close();

            listView1.Items.Clear();
            RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\GloballyOpenPorts\List");
            foreach (string kName in k.GetValueNames())
            {
                try
                {
                    string regDataLine = k.GetValue(kName).ToString();
                    string[] regDataArr = regDataLine.Split(new string[] { ":" }, StringSplitOptions.None);

                    string enableStr = "禁用";
                    if (regDataArr[3] == "Enabled") enableStr = "启用";
                    string ipStr = "所有IP";
                    if (regDataArr[2] != "*") ipStr = "特殊设置";
                    if (regDataArr[2] == "LocalSubNet") ipStr = "本地子网";

                    string[] data = new string[] { regDataArr[0], regDataArr[1], enableStr, ipStr, regDataArr[4] };

                    listView1.Items.Add(new ListViewItem(data));
                }
                catch { }
            }
            k.Close();
        }
        private void P2_LoadList_Click(object sender, EventArgs e)
        {
            RegistryKey k0 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile", true);
            if (!SmString.FindFormStringArray(k0.GetSubKeyNames(), "AuthorizedApplications")) k0.CreateSubKey("AuthorizedApplications");
            k0.Close();

            RegistryKey k1 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\AuthorizedApplications", true);
            if (!SmString.FindFormStringArray(k1.GetSubKeyNames(), "List")) k1.CreateSubKey("List");
            k1.Close();


            listView2.Items.Clear();
            RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\AuthorizedApplications\List");
            foreach (string kName in k.GetValueNames())
            {
                try
                {
                    if (kName != "")
                    {
                        string regDataLine = k.GetValue(kName).ToString();
                        string[] regDataArr = regDataLine.Split(new string[] { ":" }, StringSplitOptions.None);

                        string enableStr = "禁用";
                        if (regDataArr[3] == "Enabled") enableStr = "启用";

                        string[] data = new string[] { regDataArr[4], enableStr, regDataArr[0] + ":" + regDataArr[1] };

                        listView2.Items.Add(new ListViewItem(data));
                    }
                }
                catch { }
            }
            k.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            WindowsFirewallEditPortForm configForm = new WindowsFirewallEditPortForm(int.Parse(listView1.SelectedItems[0].Text), listView1.SelectedItems[0].SubItems[1].Text, _g);
            configForm.Submit.Click += new EventHandler(Submit_Click);
            configForm.ShowDialog();
        }
        private void P1_AddPort_Click(object sender, EventArgs e)
        {
            WindowsFirewallEditPortForm configForm = new WindowsFirewallEditPortForm(0, "TCP", _g);
            configForm.Submit.Click += new EventHandler(Submit_Click);
            configForm.ShowDialog();
        }
        private void P1_RemovePort_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count != 0)
            {
                if (MessageBox.Show("你确定删除选择的端口么？", "提问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (int.Parse(listView1.SelectedItems[0].Text) == RdpPort)
                        if (MessageBox.Show("系统检测到这是远程桌面的端口\r\n你真的要删除，如果打开的防火墙并且删除这个端口的话你将不能远程桌面了？", "提问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                    RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\GloballyOpenPorts\List", true);
                    k.DeleteValue(listView1.SelectedItems[0].Text + ":" + listView1.SelectedItems[0].SubItems[1].Text);
                    k.Close();
                    P1_LoadList_Click(sender, EventArgs.Empty);
                }
            }
        }
        void Submit_Click(object sender, EventArgs e)
        {
            P1_LoadList_Click(sender, EventArgs.Empty);
        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
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

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            WindowsFirewallEditAppForm configForm = new WindowsFirewallEditAppForm(listView2.SelectedItems[0].SubItems[2].Text, _g);
            configForm.button1.Click += new EventHandler(button1_Click);
            configForm.ShowDialog();
        }
        private void P2_AddApp_Click(object sender, EventArgs e)
        {
            WindowsFirewallEditAppForm configForm = new WindowsFirewallEditAppForm(null, _g);
            configForm.button1.Click += new EventHandler(button1_Click);
            configForm.ShowDialog();
        }
        private void P2_RemoveApp_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count != 0)
            {
                if (MessageBox.Show("你确定删除选择的程序？", "提问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\AuthorizedApplications\List", true);
                    k.DeleteValue(listView2.SelectedItems[0].SubItems[2].Text);
                    k.Close();
                    P2_LoadList_Click(sender, EventArgs.Empty);
                }
            }
        }
        void button1_Click(object sender, EventArgs e)
        {
            P2_LoadList_Click(sender, EventArgs.Empty);
        }
        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter1.SortColumn)
            {
                if (lvwColumnSorter1.Order == SortOrder.Ascending)
                    lvwColumnSorter1.Order = SortOrder.Descending;
                else
                    lvwColumnSorter1.Order = SortOrder.Ascending;
            }
            else
            {
                lvwColumnSorter1.SortColumn = e.Column;
                lvwColumnSorter1.Order = SortOrder.Ascending;
            }
            this.listView2.Sort();
        }

        private void WindowsFirewallUtility_Load(object sender, EventArgs e)
        {
            P1_LoadList_Click(sender, EventArgs.Empty);
            P2_LoadList_Click(sender, EventArgs.Empty);
        }
    }
    /// <summary>
    /// This class is an implementation of the 'IComparer' interface.
    /// </summary>
}