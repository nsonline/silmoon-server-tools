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
                    typeString = "设置应用完成";
                    break;
                case AccessRuleSetType.Appling:
                    typeString = "设置应用中..";
                    break;
                case AccessRuleSetType.Done:
                    typeString = "设置完成";
                    break;
                case AccessRuleSetType.Error:
                    typeString = "错误！";
                    break;
                case AccessRuleSetType.Finished:
                    typeString = "完成！";
                    CDriverACLSetting.Enabled = true;
                    _busy = false;
                    break;
                case AccessRuleSetType.RemoveAll:
                    typeString = "删除所有权限";
                    break;
                case AccessRuleSetType.ProcessFile:
                    typeString = "继承权限处理";
                    break;
                default:
                    break;
            }
            listBox1.Items.Add("帐户:" + e.Name + " 状态：" + typeString + " 路径" + e.FilePath);
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
                    if (MessageBox.Show("窗口正忙，确定要推出？\r\n建议等待完成工作后关闭窗体", "关闭？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    { e.Cancel = true; }
                }
            }
        }
    }
}