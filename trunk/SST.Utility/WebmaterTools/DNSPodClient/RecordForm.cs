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

namespace DNSPodClient
{
    public partial class RecordForm : Form
    {
        GBC _g;
        string _mainDomain;
        bool _newDomain;
        string _subDomain;
        int _domainID;
        int _recordID;
        public RecordForm(GBC g, string mainDomain, int domainID)
        {
            _g = g;
            _newDomain = true;
            _mainDomain = mainDomain;
            _domainID = domainID;
            InitializeComponent();
            ////this.Icon = DNSPodClient.Properties.Resources.DNSPod_1_Red;

            this.Text = "新纪录 (" + mainDomain + ")";
            ctlRecordTypeDropDownList.SelectedIndex = 0;
            ctlISPDropDownList.SelectedIndex = 0;
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public RecordForm(GBC g, string mainDomain, string subDomain, int domainID, int recordID)
        {
            _g = g;
            _newDomain = false;
            _mainDomain = mainDomain;
            _subDomain = subDomain;
            _domainID = domainID;
            _recordID = recordID;
            InitializeComponent();
            ////this.Icon = DNSPodClient.Properties.Resources.DNSPod_1_Red;
            this.Text = "编辑纪录 " + _subDomain + " (" + _mainDomain + ")";
            ctlRecordTypeDropDownList.SelectedIndex = 0;
            ctlISPDropDownList.SelectedIndex = 0;
        }


        private void ctlSubmitButton_Click(object sender, EventArgs e)
        {
            ctlSubmitButton.Enabled = false;
            ctlSubmitButton.Text = "提交中...";
            ExecAsync(Submit);
        }
        private void ctlRecordTypeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctlRecordTypeDropDownList.SelectedIndex == 2)
            {
                ctlMxLevelUpDown.Enabled = true;
                ctlMxLevelUpDown.Minimum = 1;
            }
            else
            {
                ctlMxLevelUpDown.Enabled = false;
                ctlMxLevelUpDown.Minimum = 0;
            }
        }
        private void RecordForm_Shown(object sender, EventArgs e)
        {
            ExecAsync(DrawForm);
        }

        void ExecAsync(ThreadStart start)
        {
            Thread _th = new Thread(start);
            _th.IsBackground = true;
            _th.Start();
        }
        void DrawForm()
        {
            ctlSubmitButton.Text = "正在获取域名信息...";
            fillCombo();
            ctlMainDomainLabel.Text = "." + _mainDomain;

            if (!_newDomain)
            {
                ctlSubDomainTextBox.Text = _subDomain;
                ctlSubmitButton.Enabled = false;
                RecordInfo[] infoArr = _g._dnspod.GetRecords(_domainID);
                foreach (RecordInfo info in infoArr)
                {
                    if (info.ID == _recordID)
                    {
                        ctlRecordTypeDropDownList.SelectedIndex = ((int)info.Type) - 1;
                        ctlISPDropDownList.SelectedIndex = ((int)info.Isp) - 1;
                        ctlValueTextBox.Text = info.Value;
                        ctlMxLevelUpDown.Value = info.MXLevel;
                        ctlTTLUpDown.Value = info.TTL;
                    }
                }
            }
            ctlSubmitButton.Text = "提交";
            ctlSubmitButton.Enabled = true;
        }
        void Submit()
        {
            if ("." + _mainDomain != ctlMainDomainLabel.Text)
            {
                string a = "添加";
                if (!_newDomain) a = "修改";
                if (MessageBox.Show("确定跨域" + a + "到(" + ctlMainDomainLabel.Text + ")？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }
            RecordInfo info = new RecordInfo();
            info.Subname = ctlSubDomainTextBox.Text;
            info.Type = (RecordType)ctlRecordTypeDropDownList.SelectedIndex + 1;
            info.Isp = (ISP)ctlISPDropDownList.SelectedIndex + 1;
            info.Value = ctlValueTextBox.Text;
            info.MXLevel = (int)ctlMxLevelUpDown.Value;
            info.TTL = (int)ctlTTLUpDown.Value;


            if ((info.Type == RecordType.CNAME || info.Type == RecordType.MX || info.Type == RecordType.NS) && info.Value.Substring(info.Value.Length - 1, 1) != ".")
                info.Value += ".";

            if (info.Type == RecordType.URL && SmString.CutString(info.Value, 7).ToLower() != "http://")
                info.Value = "http://" + info.Value;

            int dstDomainID = _domainID;
            if ("." + _mainDomain != ctlMainDomainLabel.Text)
                dstDomainID = _g._dnspod.GetDomainInfo(ctlMainDomainLabel.Text.Substring(1, ctlMainDomainLabel.Text.Length - 1)).ID;

            if (_newDomain)
            {
                if (_g._dnspod.CreateRecord(info, dstDomainID).DoubleStateFlag)
                    DialogResult = DialogResult.OK;
                else MessageBox.Show(this, "添加失败！", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                info.ID = _recordID;
                if (_g._dnspod.ModifyRecord(info, dstDomainID).DoubleStateFlag)
                    DialogResult = DialogResult.OK;
                else MessageBox.Show(this, "添加失败！", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ctlSubmitButton.Enabled = true;
            ctlSubmitButton.Text = "提交";
        }


        private void fillCombo()
        {
            foreach (DomainInfo domain in _g._dnspod.GetDomains())
            {
                ctlMainDomainLabel.Items.Add("." + domain.DomainName);
            }
        }

    }
}