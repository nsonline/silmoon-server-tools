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
                    if (MessageBox.Show("�����õ�����ɨ������ļ��Ĵ�С����2048KB��Ҳ����2�ס�\r\n�ڿ��ܴ��ڶ��������ļ��У�����2�׵Ŀ��ܲ����ڶ�����롣\r\n����̫�����ʧȥ���壬������", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
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