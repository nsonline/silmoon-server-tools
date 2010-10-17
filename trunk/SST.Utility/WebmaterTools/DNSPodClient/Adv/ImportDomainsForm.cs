using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Silmoon.Utility;
using System.IO;

namespace DNSPodClient.Adv
{
    public partial class ImportDomainsForm : Form
    {
        GBC _g;
        string[] fileLine;

        public ImportDomainsForm(GBC g)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            _g = g;
            InitializeComponent();
            //this.Icon = DNSPodClient.Properties.Resources.DNSPod_1_Red;
        }


        void ExecAsync(ThreadStart start)
        {
            Thread _th = new Thread(start);
            _th.IsBackground = true;
            _th.Start();
        }

        private void ctlImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "用于存储域名列表的文本文件(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK && File.Exists(ofd.FileName))
            {
                fileLine = File.ReadAllLines(ofd.FileName);

                listBox1.Items.Clear();
                foreach (string s in fileLine)
                    listBox1.Items.Add(s);

                ctlStatusText.Text = "导入成功！";
            }
        }
        private void ctlExecButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定继续？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                groupBox1.Enabled = false;
                ExecAsync(_th_exec_add_domains);
            }
        }
        void _th_exec_add_domains()
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SelectedIndex = i;
                string[] domainInfoArray = listBox1.Items[i].ToString().Split(new string[] { "\t" }, StringSplitOptions.None);
                DomainInfo record = new DomainInfo();
                record.DomainName = domainInfoArray[0];
                ctlStatusText.Text = "导入纪录(" + record.DomainName + ")";
                _g._dnspod.CreateDomain(record.DomainName);
            }
            ctlStatusText.Text = "导入完毕";
            DialogResult = DialogResult.OK;
            groupBox1.Enabled = true;
        }
    }
}