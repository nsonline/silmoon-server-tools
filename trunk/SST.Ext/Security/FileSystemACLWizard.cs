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

namespace SST.Ext.Security
{
    public partial class FileSystemACLWizard : Form
    {
        GBC _g;
        public FileSystemACLWizard(GBC g)
        {
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            _g = g;
            Show();
        }

        private void FileSystemACLWizard_Load(object sender, EventArgs e)
        {

        }

        private void C_WebWizard_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "选择一个你要设置的网站的目录或者盘符";
            fbd.ShowDialog();
            if (!string.IsNullOrEmpty(fbd.SelectedPath))
            {
                DirectorySecurity dirsec = Directory.GetAccessControl(fbd.SelectedPath);
                dirsec.SetAccessRuleProtection(true, false);
                dirsec = ACL.RemoveAllSystemAccessRule(dirsec);
                dirsec = ACL.AddAccessRule(dirsec, "SYSTEM", FileSystemRights.FullControl, true);
                dirsec = ACL.AddAccessRule(dirsec, "Administrators", FileSystemRights.FullControl, true);
                dirsec.AddAccessRule(new FileSystemAccessRule("NETWORK SERVICE", FileSystemRights.Read, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
                dirsec.AddAccessRule(new FileSystemAccessRule("NETWORK SERVICE", FileSystemRights.Read, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                Directory.SetAccessControl(fbd.SelectedPath, dirsec);
                MessageBox.Show("设置完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fbd.Dispose();
        }
        private void C_DataBaseWizard_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "选择一个你要设置的数据库的目录或者盘符";
            fbd.ShowDialog();
            if (!string.IsNullOrEmpty(fbd.SelectedPath))
            {
                DirectorySecurity dirsec = Directory.GetAccessControl(fbd.SelectedPath);
                dirsec.SetAccessRuleProtection(true, false);
                dirsec = ACL.RemoveAllSystemAccessRule(dirsec);
                dirsec = ACL.AddAccessRule(dirsec, "SYSTEM", FileSystemRights.FullControl, true);
                dirsec = ACL.AddAccessRule(dirsec, "Administrators", FileSystemRights.FullControl, true);
                Directory.SetAccessControl(fbd.SelectedPath, dirsec);
                MessageBox.Show("设置完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fbd.Dispose();

        }
        private void C_OtherWizard_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "选择一个你要设置的目录或者盘符";
            fbd.ShowDialog();
            if (!string.IsNullOrEmpty(fbd.SelectedPath))
            {
                DirectorySecurity dirsec = Directory.GetAccessControl(fbd.SelectedPath);
                dirsec.SetAccessRuleProtection(true, false);
                dirsec = ACL.RemoveAllSystemAccessRule(dirsec);
                dirsec = ACL.AddAccessRule(dirsec, "SYSTEM", FileSystemRights.FullControl, true);
                dirsec = ACL.AddAccessRule(dirsec, "Administrators", FileSystemRights.FullControl, true);
                Directory.SetAccessControl(fbd.SelectedPath, dirsec);
                MessageBox.Show("设置完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fbd.Dispose();

        }

        private void FileSystemACLWizard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }
    }
}