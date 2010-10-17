using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.AccessControl;
using Silmoon.IO.SmFile;
using System.Windows.Forms;
using SST.Common;

namespace SST.Ext.Security
{
    public class FileSecuritySettingsClass:IDisposable
    {
        GBC _g;
        public FileSecuritySettingsClass(GBC g)
        {
            _g = g;
        }

        public void PhpFileSecuritySettings()
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"c:\php\");
            DirectorySecurity dirsecurity = dirinfo.GetAccessControl();
            dirsecurity.AddAccessRule(new FileSystemAccessRule("NETWORK SERVICE", FileSystemRights.ReadAndExecute, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("NETWORK SERVICE", FileSystemRights.ReadAndExecute, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("NETWORK", FileSystemRights.ReadAndExecute, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("NETWORK", FileSystemRights.ReadAndExecute, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("Administrators", FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("Administrators", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("SYSTEM", FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("SYSTEM", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.SetAccessRuleProtection(true, false);
            dirinfo.SetAccessControl(dirsecurity);
            _g.LoggerObj.WriteLogLine("(FSE)C:\\PHP 访问控制处理完毕");
        }
        public void SetSpecialFileSecurity()
        {
            SpecialFileSecurity(@"c:\windows\system32\net.exe");
            SpecialFileSecurity(@"c:\windows\system32\net1.exe");
            SpecialFileSecurity(@"c:\windows\system32\cmd.exe");
            SpecialFileSecurity(@"c:\windows\system32\tftp.exe");
            SpecialFileSecurity(@"c:\windows\system32\netstat.exe");
            SpecialFileSecurity(@"c:\windows\system32\regedt32.exe");
            SpecialFileSecurity(@"c:\windows\regedit.exe");
            SpecialFileSecurity(@"c:\windows\system32\at.exe");
            SpecialFileSecurity(@"c:\windows\system32\attrib.exe");
            SpecialFileSecurity(@"c:\windows\system32\cacls.exe");
            SpecialFileSecurity(@"c:\windows\system32\format.com");
            SpecialFileSecurity(@"c:\windows\system32\sethc.com");

            SpecialFileSecurity(@"c:\windows\system32\dllcache\net.exe");
            SpecialFileSecurity(@"c:\windows\system32\dllcache\net1.exe");
            SpecialFileSecurity(@"c:\windows\system32\dllcache\cmd.exe");
            SpecialFileSecurity(@"c:\windows\system32\dllcache\tftp.exe");
            SpecialFileSecurity(@"c:\windows\system32\dllcache\netstat.exe");
            SpecialFileSecurity(@"c:\windows\system32\dllcache\regedt32.exe");
            SpecialFileSecurity(@"c:\windows\system32\dllcache\regedit.exe");
            SpecialFileSecurity(@"c:\windows\system32\dllcache\at.exe");
            SpecialFileSecurity(@"c:\windows\system32\attrib.exe");
            SpecialFileSecurity(@"c:\windows\system32\dllcache\cacls.exe");
            SpecialFileSecurity(@"c:\windows\system32\dllcache\format.com");
            SpecialFileSecurity(@"c:\windows\system32\dllcache\sethc.com");
            _g.LoggerObj.WriteLogLine("(FSE)特殊文件处理完毕！");
        }
        public void ResetSpecialFileSecurity()
        {
            ResetSpecialFileSrcutity(@"c:\windows\system32\net.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\net1.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\cmd.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\tftp.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\netstat.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\regedt32.exe");
            ResetSpecialFileSrcutity(@"c:\windows\regedit.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\at.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\attrib.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\cacls.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\format.com");

            ResetSpecialFileSrcutity(@"c:\windows\system32\dllcache\net.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\dllcache\net1.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\dllcache\cmd.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\dllcache\tftp.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\dllcache\netstat.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\dllcache\regedt32.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\dllcache\regedit.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\dllcache\at.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\attrib.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\dllcache\cacls.exe");
            ResetSpecialFileSrcutity(@"c:\windows\system32\dllcache\format.com");
            _g.LoggerObj.WriteLogLine("(FSE)特殊文件处理完毕！");
        }
        void SpecialFileSecurity(string filePath)
        {
            bool b = false;
            if (filePath.IndexOf("dllcache") == -1) { b = true; }
            try
            {
                ACL.RemoveAllSystemAccessRule(filePath);
                FileSystemAccessRule fsar = new FileSystemAccessRule("Administrators", FileSystemRights.FullControl, AccessControlType.Allow);
                FileSecurity sec = File.GetAccessControl(filePath);
                sec.AddAccessRule(fsar);
                sec.SetAccessRuleProtection(true, false);
                File.SetAccessControl(filePath, sec);
                if (b) _g.LoggerObj.WriteLogLine("(FSE)" + Path.GetFileName(filePath) + " 权限处理完毕", 0);
            }
            catch { if (b)_g.LoggerObj.WriteLogLine("(FSE)" + Path.GetFileName(filePath) + " 处理错误", 0); }
        }
        void ResetSpecialFileSrcutity(string filePath)
        {
            bool b = false;
            if (filePath.IndexOf("dllcache") == -1) { b = true; }
            try
            {
                ACL.RemoveAllSystemAccessRule(filePath);
                FileSystemAccessRule fsar = new FileSystemAccessRule("Administrators", FileSystemRights.FullControl, AccessControlType.Allow);
                FileSecurity sec = File.GetAccessControl(filePath);
                sec.RemoveAccessRule(fsar);
                sec.SetAccessRuleProtection(false, false);
                File.SetAccessControl(filePath, sec);
                if (b) _g.LoggerObj.WriteLogLine("(FSE)" + Path.GetFileName(filePath) + " 权限重置完毕", 0);
            }
            catch { if (b)_g.LoggerObj.WriteLogLine("(FSE)" + Path.GetFileName(filePath) + " 重置错误", 0); }
        }
        public void SethcFileSecurity()
        {
            try
            {
                FileSecurity fs = File.GetAccessControl(@"c:\windows\system32\sethc.exe");
                fs.SetAccessRuleProtection(true, false);
                File.SetAccessControl(@"c:\windows\system32\sethc.exe", fs);
                FileSecurity fs1 = File.GetAccessControl(@"c:\windows\system32\dllcache\sethc.exe");
                fs1.SetAccessRuleProtection(true, false);
                File.SetAccessControl(@"c:\windows\system32\dllcache\sethc.exe", fs1);

                ACL.RemoveAllSystemAccessRule(@"c:\windows\system32\sethc.exe");
                ACL.RemoveAllSystemAccessRule(@"c:\windows\system32\dllcache\sethc.exe");
                MessageBox.Show("操作成功完成", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _g.LoggerObj.WriteLogLine("(FSE)粘滞键安全设置");
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        public void SethcFileSecurityHard()
        {
            try
            {
                if (File.Exists(@"c:\windows\system32\sethc.exe"))
                {
                    File.Delete(@"c:\windows\system32\sethc.exe");
                    _g.LoggerObj.WriteLogLine("(FSE)删除SETHC.EXE!");
                }
                if (CommonFunctions.createUndeleteFile(@"c:\windows\system32\sethc.exe", ref _g))
                {
                    _g.LoggerObj.WriteLogLine("(FSE)创建免疫SETHC.EXE!");
                    MessageBox.Show("完成操作！", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _g.LoggerObj.WriteLogLine("(FSE)已存在SETHC.EXE免疫!");
                    MessageBox.Show("已经存在粘滞键免疫遗留！", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        public void ResetSethcFileSecurity()
        {
            try
            {
                ACL.RemoveAllSystemAccessRule(@"c:\windows\system32\sethc.exe");
                FileSecurity sec = File.GetAccessControl(@"c:\windows\system32\sethc.exe");
                sec.SetAccessRuleProtection(false, false);
                File.SetAccessControl(@"c:\windows\system32\sethc.exe", sec);

                ACL.RemoveAllSystemAccessRule(@"c:\windows\system32\dllcache\sethc.exe");
                FileSecurity sec1 = File.GetAccessControl(@"c:\windows\system32\dllcache\sethc.exe");
                sec1.SetAccessRuleProtection(false, false);
                File.SetAccessControl(@"c:\windows\system32\dllcache\sethc.exe", sec1);
                MessageBox.Show("反操作成功完成", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _g.LoggerObj.WriteLogLine("(FSE)粘滞键安全恢复");
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        public int RejectIISUser(string text)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = text;
                fbd.ShowDialog();
                if (Directory.Exists(fbd.SelectedPath))
                {
                    DirectorySecurity ds = Directory.GetAccessControl(fbd.SelectedPath);
                    ds.AddAccessRule(new FileSystemAccessRule("NETWORK SERVICE", FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Deny));
                    ds.AddAccessRule(new FileSystemAccessRule("NETWORK SERVICE", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
                    ds.AddAccessRule(new FileSystemAccessRule("NETWORK", FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Deny));
                    ds.AddAccessRule(new FileSystemAccessRule("NETWORK", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
                    Directory.SetAccessControl(fbd.SelectedPath, ds);
                    _g.LoggerObj.WriteLogLine("(FSE) Serv-U目录安全设置完成");
                    return 1;
                }
                return 2;
            }
            catch (Exception ex)
            {
                _g.PopErrorMessage(ex.Message);
                _g.LoggerObj.WriteLogLine("(FSE)" + ex.Message);
                return 0;
            }
        }
        public int ResetRejectIISUser(string text)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                fbd.Description = text;
                if (Directory.Exists(fbd.SelectedPath))
                {
                    DirectorySecurity ds = Directory.GetAccessControl(fbd.SelectedPath);
                    ds.RemoveAccessRule(new FileSystemAccessRule("NETWORK SERVICE", FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Deny));
                    ds.RemoveAccessRule(new FileSystemAccessRule("NETWORK SERVICE", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
                    ds.RemoveAccessRule(new FileSystemAccessRule("NETWORK", FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Deny));
                    ds.RemoveAccessRule(new FileSystemAccessRule("NETWORK", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
                    Directory.SetAccessControl(fbd.SelectedPath, ds);
                    _g.LoggerObj.WriteLogLine("(FSE) Serv-U目录安全重置完成");
                    return 1;
                }
                return 2;
            }
            catch (Exception ex)
            {
                _g.PopErrorMessage(ex.Message);
                _g.LoggerObj.WriteLogLine("(FSE)" + ex.Message);
                return 0;
            }
        }

        #region IDisposable 成员

        public void Dispose()
        {

        }

        #endregion
    }
}
