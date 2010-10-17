using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using Silmoon.IO.SmFile;
using System.Diagnostics;

namespace SST.Ext.Security
{
    public partial class FileSecuritySetupForm : Form
    {
        GBC _g;
        Timer _t;
        FileSecuritySettingsClass fssecClass;
        bool _busy = false;

        public FileSecuritySetupForm(GBC g)
        {
            _g = g;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            _t = new Timer();
            _t.Tick += new EventHandler(_t_Tick);
            _t.Interval = 1000;
            fssecClass = new FileSecuritySettingsClass(_g);
            Show();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void _t_Tick(object sender, EventArgs e)
        {
            TipStatus.Text = "...";
            _t.Stop();
        }

        private void SetPHPSecurity_Click(object sender, EventArgs e)
        {
            try
            {
                fssecClass.PhpFileSecuritySettings();
                TipStatus.Text = "C:\\PHP �������";
                _t.Start();
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        private void SetSpecialFileSecurity_Click(object sender, EventArgs e)
        {
            try
            {
                fssecClass.SetSpecialFileSecurity();

                TipStatus.Text = "�������";
                _t.Start();
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        private void ResetSpecialFileSecurity_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("�ָ����úõ������ļ�Ȩ�ޣ�", "ȷ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fssecClass.ResetSpecialFileSecurity();
                    TipStatus.Text = "�������";
                    _t.Start();
                }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        private void CWizard_Click(object sender, EventArgs e)
        {
            new DriverFileSecurityWizard(_g);
        }
        private void ResetCACL_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ȷ��Ҫ����C���ļ�������Ȩ�ޣ�\r\n�⽫����ϵͳ�̵�����Ŀ¼���ļ�Ȩ�޻ָ������İ�ȫ���ã�", "ѯ��", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Process p = new Process();
                    p.StartInfo.WorkingDirectory = @"C:\windows\system32";
                    p.StartInfo.FileName = @"Secedit";
                    p.StartInfo.Arguments = @" /configure /db C:\windows\security\database\cvtfs.sdb /Cfg ""C:\windows\security\templates\setup security.inf"" /areas filestore";
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    p.EnableRaisingEvents = true;
                    p.Exited += new EventHandler(p_Exited);
                    p.Start();
                    TipStatus.Text = "ִ���У��ȴ��������...";
                    groupBox1.Enabled = false;
                    _busy = true;
                    _g.LoggerObj.WriteLogLine("����C���ļ�Ȩ�޿�ʼ...");
                }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        void p_Exited(object sender, EventArgs e)
        {
            try
            {
                _g.LoggerObj.WriteLogLine("�߳��˳�������C�����");
                Control.CheckForIllegalCrossThreadCalls = false;
                groupBox1.Enabled = true;
                TipStatus.Text = "ִ�����...";
                _busy = false;
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
            Process p = (Process)sender;
            p.Exited -= new EventHandler(p_Exited);
            p.Close();
            p.Dispose();
            p = null;
        }

        private void FileSecuritySetupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (_busy)
                {
                    if (MessageBox.Show("������æ��ȷ��Ҫ�˳���\r\n����ȴ���ɹ�����رմ���", "�رգ�", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    { e.Cancel = true; }
                }
            }
        }
        private void FileSecuritySetupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fssecClass.Dispose();
        }

        private void ctlServUFileSecurityButton_Click(object sender, EventArgs e)
        {
            int i = fssecClass.RejectIISUser("��ָ��Serv-U�İ�װĿ¼!\r\nһ��Ҫָ��Serv-U�İ�װĿ¼!\r\n����IIS���в�������");
            if (i == 1) MessageBox.Show("������ɣ�", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (i == 2) MessageBox.Show("ȡ��������", "_war", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("��������", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ctlReServUFileSecurityButton_Click(object sender, EventArgs e)
        {
            int i = fssecClass.ResetRejectIISUser("��ָ��Serv-U�Ѿ����ù���Ŀ¼");
            if (i == 1) MessageBox.Show("������ɣ�", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (i == 2) MessageBox.Show("ȡ��������", "_war", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("��������", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}