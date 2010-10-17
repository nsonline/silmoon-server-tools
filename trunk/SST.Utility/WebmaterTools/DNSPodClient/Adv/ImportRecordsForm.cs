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
    public partial class ImportRecordsForm : Form
    {
        GBC _g;
        string _domain;
        int _domainID;
        string[] fileLine;
        DomainInfo _importDomain;

        public ImportRecordsForm(GBC g, string domain, int domainID)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            _g = g;
            _domain = domain;
            _domainID = domainID;
            InitializeComponent();
            //this.Icon = DNSPodClient.Properties.Resources.DNSPod_1_Red;
            this.Text = "���봰�� ��ǰ�� (" + _domain + ")";
        }

        private void ctlJumpButton_Click(object sender, EventArgs e)
        {
            if (ctlJumpButton.Text == "ȷ��(&J)")
            {
                ctlJumpCombo.Enabled = false;
                string[] jumpListStringArray = ctlJumpCombo.Text.Split(new string[] { ")", "(" }, StringSplitOptions.RemoveEmptyEntries);
                _domain = jumpListStringArray[0];
                _domainID = int.Parse(jumpListStringArray[1]);
                this.Text = "���봰�� ��ǰ�� (" + _domain + ")";
                ctlJumpButton.Text = "����(&J)";
            }
            else
            {
                ctlJumpButton.Enabled = false;
                ExecAsync(_th_Jump_getList);
            }
        }

        private void ImportRecordsForm_Shown(object sender, EventArgs e)
        {
            ctlJumpCombo.Items.Add(_domain);
            ctlJumpCombo.SelectedIndex = 0;
        }
        void ExecAsync(ThreadStart start)
        {
            Thread _th = new Thread(start);
            _th.IsBackground = true;
            _th.Start();
        }


        void _th_Jump_getList()
        {
            ctlJumpButton.Text = "���Ե�...(&J)";
            ctlJumpCombo.Items.Clear();
            foreach (DomainInfo info in _g._dnspod.GetDomains())
            {
                ctlJumpCombo.Items.Add(info.DomainName + "(" + info.ID + ")");
            }
            ctlJumpCombo.SelectedItem = _domain + "(" + _domainID + ")";
            ctlJumpButton.Enabled = true;
            ctlJumpCombo.Enabled = true;
            ctlJumpButton.Text = "ȷ��(&J)";
        }

        private void ctlImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "���ڴ洢������¼���ı��ļ�(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK && File.Exists(ofd.FileName))
            {
                fileLine = File.ReadAllLines(ofd.FileName);
                if (fileLine.Length > 1)
                {
                    string[] headLine = fileLine[0].Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                    if (fileLine.Length > 3)
                    {
                        if (headLine[0] == "?RecordList")
                            ctlListTypeLabe.Text = "��¼�б�";
                        else
                        {
                            MessageBox.Show("��¼�б������ָ����ȷ�ļ�¼�б�(head tag error)", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ctlStatusText.Text = "����ʧ�ܣ�";
                            fileLine = null;
                            return;
                        }
                        ctlRecordsTotalLabel.Text = ((int)(fileLine.Length - 1)).ToString();
                        ctlDomainLabel.Text = headLine[2];
                        _importDomain = new DomainInfo();
                        _importDomain.ID = int.Parse(headLine[1]);
                        _importDomain.DomainName = headLine[2];
                        if (_importDomain.DomainName.ToLower() != _domain.ToLower())
                            MessageBox.Show("ע�⣬��������б��ļ����ǵ�ǰ���������ģ�");

                        listBox1.Items.Clear();
                        for (int i = 0; i < fileLine.Length - 1; i++)
                            listBox1.Items.Add(fileLine[i + 1]);
                    }
                    else
                    {
                        MessageBox.Show("��¼�б������ָ����ȷ�ļ�¼�б�(head parameter lenght error)", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ctlStatusText.Text = "����ʧ�ܣ�";
                        fileLine = null;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("��¼�б������ָ����ȷ�ļ�¼�б�(lines error)", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctlStatusText.Text = "����ʧ�ܣ�";
                    fileLine = null;
                    return;
                }
                ctlStatusText.Text = "����ɹ���";
            }
        }
        private void ctlExecButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("��Ҫ������Ϊ(" + _domain + ")������Ѿ���������м�¼\r\n�����ǰ��������ͬ���ļ�¼�ǻ��ظ���ӵģ�������", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                groupBox1.Enabled = false;
                groupBox3.Enabled = false;
                ExecAsync(_th_exec_add_records);
            }
        }
        void _th_exec_add_records()
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SelectedIndex = i;
                string[] recordInfoArray = listBox1.Items[i].ToString().Split(new string[] { "\t" }, StringSplitOptions.None);
                RecordInfo record = new RecordInfo();
                record.Enable = true;
                record.ID = int.Parse(recordInfoArray[6]);
                record.Isp = DNSPod.StringToISP(recordInfoArray[2]);
                record.MXLevel = int.Parse(recordInfoArray[4]);
                record.Subname = recordInfoArray[0];
                record.TTL = int.Parse(recordInfoArray[5]);
                record.Type = DNSPod.StringToRecordType(recordInfoArray[1]);
                record.Value = recordInfoArray[3];
                ctlStatusText.Text = "�����¼(" + record.Subname + ")";
                _g._dnspod.CreateRecord(record, _domainID);
            }
            ctlStatusText.Text = "�������";
            DialogResult = DialogResult.OK;
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
        }
    }
}