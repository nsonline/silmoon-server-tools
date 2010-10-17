using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SST.Ext.Tools
{
    public partial class ScanCodeOptionWindow : Form
    {
        ScanOption _scanOption;
        GBC _g;
        public ScanCodeOptionWindow(GBC g,ScanOption scanOption)
        {
            InitializeComponent();
            _g = g;
            _scanOption = scanOption;
        }

        private void ctlComfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (long.Parse(ctlFileSizeUpDown.Text) > 2048)
                    if (MessageBox.Show("您设置的允许扫描最大文件的大小大于2048KB，也就是2兆。\r\n在可能存在恶意代码的文件中，大于2兆的可能不存在恶意代码。\r\n设置太大可能失去意义，继续？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;

                _scanOption.FileMaxSizeKB = long.Parse(ctlFileSizeUpDown.Text);
                Close();
            }
            catch (Exception ex)
            { _g.ProtectRunAsClass(ex.ToString()); }
        }

        private void ScanCodeOptionWindow_Load(object sender, EventArgs e)
        {
            DrawForm();
        }
        void DrawForm()
        {
            ctlFileSizeUpDown.Value = _scanOption._fileMaxSizeKB;
        }
    }
}