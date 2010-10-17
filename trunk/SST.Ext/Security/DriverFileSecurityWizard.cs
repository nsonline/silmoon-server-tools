using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SST.Ext.Security
{
    public partial class DriverFileSecurityWizard : Form
    {
        GBC _g;
        CDriverWizardClass cdc;
        bool _busy = false;
        public DriverFileSecurityWizard(GBC g)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            _g = g;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            Show();
            cdc = new CDriverWizardClass(_g, false);
            cdc.OnSetAccessRuleStatusChange += new AccessRuleSetHander(cdc_SetAccessRuleStatusChange);
        }

        private void DriverWizard_Load(object sender, EventArgs e)
        {

        }

        private void CDriverACLSetting_Click(object sender, EventArgs e)
        {
            cdc.StartSettings();
            CDriverACLSetting.Enabled = false;
        }

        void cdc_SetAccessRuleStatusChange(object sender, AccessRuleSetArgs e)
        {
            _busy = true;
            string typeString = null;
            switch (e.Type)
            {
                case AccessRuleSetType.Applied:
                    typeString = "����Ӧ�����";
                    break;
                case AccessRuleSetType.Appling:
                    typeString = "����Ӧ����..";
                    break;
                case AccessRuleSetType.Done:
                    typeString = "�������";
                    break;
                case AccessRuleSetType.Error:
                    typeString = "����";
                    break;
                case AccessRuleSetType.Finished:
                    typeString = "��ɣ�";
                    CDriverACLSetting.Enabled = true;
                    _busy = false;
                    break;
                case AccessRuleSetType.RemoveAll:
                    typeString = "ɾ������Ȩ��";
                    break;
                case AccessRuleSetType.ProcessFile:
                    typeString = "�̳�Ȩ�޴���";
                    break;
                default:
                    break;
            }
            listBox1.Items.Add("�ʻ�:" + e.Name + " ״̬��" + typeString + " ·��" + e.FilePath);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void DriverWizard_FormClosed(object sender, FormClosedEventArgs e)
        {
            cdc.OnSetAccessRuleStatusChange -= new AccessRuleSetHander(cdc_SetAccessRuleStatusChange);
            cdc.Dispose();
            Dispose(true);
        }
        private void DriverWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (_busy)
                {
                    if (MessageBox.Show("������æ��ȷ��Ҫ�Ƴ���\r\n����ȴ���ɹ�����رմ���", "�رգ�", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    { e.Cancel = true; }
                }
            }
        }
    }
}