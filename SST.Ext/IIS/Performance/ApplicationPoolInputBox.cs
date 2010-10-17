using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SST.Ext.IIS.Performance
{
    public partial class ApplicationPoolInputBox : Form
    {
        int _option = 0;
        public string PoolNameInfo
        {
            get
            {
                return ctlNameTextBox.Text;
            }
        }
        public ApplicationPoolInputBox(int option)
        {
            InitializeComponent();
            _option = option;
            if (option == 1)
            {
                label1.Text = "新的应用池名称";
                ctlNameTextBox.Text = "AppPool_Merge_" + DateTime.Now.ToString("yyyyMMddhhmmss");
            }
            else
            {
                label1.Text = "拆分应用池名称前缀 最终结果格式：\r\n    (前缀_网站名称_网站ID)";
                ctlNameTextBox.Text = "AppPool_Split";
            }
            ctlNameTextBox.SelectAll();
        }

        private void ctlComfirmButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ctlNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_option == 0)
                label1.Text = "拆分应用池名称前缀 最终结果格式：\r\n    (" + ctlNameTextBox.Text + "_网站名称_网站ID)";
        }
    }
}