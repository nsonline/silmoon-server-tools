using System;
using System.Collections.Generic;
using System.Text;
using Silmoon.IO.SmFile;
using System.IO;
using System.Security.AccessControl;
using System.Threading;

namespace SST.Ext.Security
{
    class CDriverWizardClass : IDisposable
    {
        public event AccessRuleSetHander OnSetAccessRuleStatusChange;

        AccessRuleSetArgs _args = new AccessRuleSetArgs();
        GBC _g;
        Thread _t;
        public CDriverWizardClass(GBC g, bool autoStart)
        {
            _g = g;
            _t = new Thread(_th_set_thead);
            if (autoStart) StartSettings();
        }
        public void StartSettings()
        {
            if (_t.ThreadState != ThreadState.Unstarted && _t.ThreadState != ThreadState.Background)
                _t = new Thread(_th_set_thead);
            _t.IsBackground = true;
            if (_t.ThreadState != ThreadState.Running)
                _t.Start();
        }
        private void _th_set_thead()
        {
            _g.LoggerObj.WriteLogLine("(FSE)驱动器C安全过程启动...");
            _args.FilePath = "C:";
            DirectorySecurity c_sec = Directory.GetAccessControl("C:");
            c_sec = ACL.RemoveAllSystemAccessRule(c_sec);
            _args.Type = AccessRuleSetType.RemoveAll;
            _args.Name = "NULL";
            onSetAccessRuleStatusChange(_args);
            c_sec = AddAccessRule(c_sec, "SYSTEM", FileSystemRights.FullControl, true);
            c_sec = AddAccessRule(c_sec, "Administrators", FileSystemRights.FullControl, true);
            _args.Name = "NULL";
            _args.Type = AccessRuleSetType.Appling;
            onSetAccessRuleStatusChange(_args);
            Directory.SetAccessControl("C:", c_sec);
            _args.Type = AccessRuleSetType.Applied;
            onSetAccessRuleStatusChange(_args);



            _args.FilePath = "C:\\Windows";
            DirectorySecurity windows_sec = Directory.GetAccessControl("C:\\Windows");
            windows_sec = ACL.RemoveAllSystemAccessRule(windows_sec);
            _args.Type = AccessRuleSetType.RemoveAll;
            _args.Name = "NULL";
            onSetAccessRuleStatusChange(_args);
            windows_sec = AddAccessRule(windows_sec, "SYSTEM", FileSystemRights.FullControl, true);
            windows_sec = AddAccessRule(windows_sec, "Administrators", FileSystemRights.FullControl, true);
            windows_sec = AddAccessRule(windows_sec, "NETWORK SERVICE", FileSystemRights.ReadAndExecute, true);
            windows_sec = AddAccessRule(windows_sec, "LOCAL SERVICE", FileSystemRights.FullControl, true);
            windows_sec = AddAccessRule(windows_sec, "NETWORK", FileSystemRights.ReadAndExecute, true);
            windows_sec = AddAccessRule(windows_sec, "IIS_WPG", FileSystemRights.ReadAndExecute, true);
            _args.Name = "NULL";
            _args.Type = AccessRuleSetType.Appling;
            onSetAccessRuleStatusChange(_args);
            Directory.SetAccessControl("C:\\Windows", windows_sec);
            _args.Type = AccessRuleSetType.Applied;
            onSetAccessRuleStatusChange(_args);


            _args.Name = "NULL";
            _args.Type = AccessRuleSetType.ProcessFile;
            _args.FilePath = "C:\\Windows";
            onSetAccessRuleStatusChange(_args);
            string[] sysArr = Directory.GetFiles("C:\\Windows", "*.*", SearchOption.TopDirectoryOnly);
            AddProtection(sysArr);
            _args.Type = AccessRuleSetType.Applied;
            onSetAccessRuleStatusChange(_args);


            _args.FilePath = "C:\\Windows\\System32";
            DirectorySecurity windowssys32_sec = Directory.GetAccessControl("C:\\Windows\\System32");
            windowssys32_sec = ACL.RemoveAllSystemAccessRule(windowssys32_sec);
            windowssys32_sec.SetAccessRuleProtection(true, false);
            _args.Type = AccessRuleSetType.RemoveAll;
            _args.Name = "NULL";
            onSetAccessRuleStatusChange(_args);
            windowssys32_sec = AddAccessRule(windowssys32_sec, "SYSTEM", FileSystemRights.FullControl, true);
            windowssys32_sec = AddAccessRule(windowssys32_sec, "Administrators", FileSystemRights.FullControl, true);
            windowssys32_sec = AddAccessRule(windowssys32_sec, "NETWORK SERVICE", FileSystemRights.ReadAndExecute, true);
            windowssys32_sec = AddAccessRule(windowssys32_sec, "LOCAL SERVICE", FileSystemRights.FullControl, true);
            windowssys32_sec = AddAccessRule(windowssys32_sec, "NETWORK", FileSystemRights.ReadAndExecute, true);
            windowssys32_sec = AddAccessRule(windowssys32_sec, "IIS_WPG", FileSystemRights.ReadAndExecute, true);
            _args.Name = "NULL";
            _args.Type = AccessRuleSetType.Appling;
            onSetAccessRuleStatusChange(_args);
            Directory.SetAccessControl("C:\\Windows\\System32", windowssys32_sec);
            _args.Type = AccessRuleSetType.Applied;
            onSetAccessRuleStatusChange(_args);


            _args.Name = "NULL";
            _args.Type = AccessRuleSetType.ProcessFile;
            _args.FilePath = "C:\\Windows\\System32";
            onSetAccessRuleStatusChange(_args);
            string[] sys32Arr = Directory.GetFiles("C:\\Windows\\System32", "*.*", SearchOption.TopDirectoryOnly);
            AddProtection(sys32Arr);
            _args.Type = AccessRuleSetType.Applied;
            onSetAccessRuleStatusChange(_args);



            _args.FilePath = "C:\\Program Files";
            DirectorySecurity programFile_sec = Directory.GetAccessControl("C:\\Program Files");
            programFile_sec = ACL.RemoveAllSystemAccessRule(programFile_sec);
            _args.Type = AccessRuleSetType.RemoveAll;
            _args.Name = "NULL";
            onSetAccessRuleStatusChange(_args);
            programFile_sec = AddAccessRule(programFile_sec, "SYSTEM", FileSystemRights.FullControl, true);
            programFile_sec = AddAccessRule(programFile_sec, "Administrators", FileSystemRights.FullControl, true);
            programFile_sec = AddAccessRule(programFile_sec, "NETWORK SERVICE", FileSystemRights.ReadAndExecute, true);
            programFile_sec = AddAccessRule(programFile_sec, "NETWORK", FileSystemRights.ReadAndExecute, true);
            programFile_sec = AddAccessRule(programFile_sec, "LOCAL SERVICE", FileSystemRights.ReadAndExecute, true);
            programFile_sec = AddAccessRule(programFile_sec, "IIS_WPG", FileSystemRights.ReadAndExecute, true);
            _args.Name = "NULL";
            _args.Type = AccessRuleSetType.Appling;
            onSetAccessRuleStatusChange(_args);
            Directory.SetAccessControl("C:\\Program Files", programFile_sec);
            _args.Type = AccessRuleSetType.Applied;
            onSetAccessRuleStatusChange(_args);


            _args.FilePath = "C:\\Program Files\\Common Files";
            DirectorySecurity programFileCommon_sec = Directory.GetAccessControl("C:\\Program Files\\Common Files");
            programFileCommon_sec = ACL.RemoveAllSystemAccessRule(programFileCommon_sec);
            _args.Type = AccessRuleSetType.RemoveAll;
            _args.Name = "NULL";
            onSetAccessRuleStatusChange(_args);
            programFile_sec = AddAccessRule(programFileCommon_sec, "NETWORK", FileSystemRights.ReadAndExecute, true);
            _args.Name = "NULL";
            _args.Type = AccessRuleSetType.Appling;
            onSetAccessRuleStatusChange(_args);
            Directory.SetAccessControl("C:\\Program Files\\Common Files", programFileCommon_sec);
            _args.Type = AccessRuleSetType.Applied;
            onSetAccessRuleStatusChange(_args);


            _args.FilePath = "C:\\Documents and Settings";
            DirectorySecurity documentSettings_sec = Directory.GetAccessControl("C:\\Documents and Settings");
            programFile_sec = ACL.RemoveAllSystemAccessRule(documentSettings_sec);
            _args.Type = AccessRuleSetType.RemoveAll;
            _args.Name = "NULL";
            onSetAccessRuleStatusChange(_args);
            programFile_sec = AddAccessRule(programFile_sec, "SYSTEM", FileSystemRights.FullControl, true);
            programFile_sec = AddAccessRule(programFile_sec, "Administrators", FileSystemRights.FullControl, true);
            programFile_sec = AddAccessRule(programFile_sec, "NETWORK SERVICE", FileSystemRights.ReadAndExecute, true);
            programFile_sec = AddAccessRule(programFile_sec, "LOCAL SERVICE", FileSystemRights.ReadAndExecute, true);
            programFile_sec = AddAccessRule(programFile_sec, "IIS_WPG", FileSystemRights.ReadAndExecute, true);
            _args.Name = "NULL";
            _args.Type = AccessRuleSetType.Appling;
            onSetAccessRuleStatusChange(_args);
            Directory.SetAccessControl("C:\\Documents and Settings", documentSettings_sec);
            _args.Type = AccessRuleSetType.Applied;
            onSetAccessRuleStatusChange(_args);


            _args.FilePath = @"C:\WINDOWS\Temp";
            DirectorySecurity tmp_sec = Directory.GetAccessControl(@"C:\WINDOWS\Temp");
            tmp_sec = AddAccessRule(tmp_sec, "Users", FileSystemRights.FullControl, true);
            _args.Name = "NULL";
            _args.Type = AccessRuleSetType.Appling;
            onSetAccessRuleStatusChange(_args);
            Directory.SetAccessControl(@"C:\WINDOWS\Temp", tmp_sec);
            _args.Type = AccessRuleSetType.Applied;
            onSetAccessRuleStatusChange(_args);

            try
            {
                _args.FilePath = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\Temporary ASP.NET Files";
                DirectorySecurity net1tmp_sec = Directory.GetAccessControl(@"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\Temporary ASP.NET Files");
                net1tmp_sec = AddAccessRule(net1tmp_sec, "NETWORK SERVICE", FileSystemRights.FullControl, true);
                //net1tmp_sec = AddAccessRule(net1tmp_sec, "IIS_WPG", FileSystemRights.Read, true);
                _args.Name = "NULL";
                _args.Type = AccessRuleSetType.Appling;
                onSetAccessRuleStatusChange(_args);
                Directory.SetAccessControl(@"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\Temporary ASP.NET Files", net1tmp_sec);
                _args.Type = AccessRuleSetType.Applied;
                onSetAccessRuleStatusChange(_args);
            }
            catch { }

            try
            {
                _args.FilePath = @"C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\Temporary ASP.NET Files";
                DirectorySecurity net2tmp_sec = Directory.GetAccessControl(@"C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\Temporary ASP.NET Files");
                net2tmp_sec = AddAccessRule(net2tmp_sec, "NETWORK SERVICE", FileSystemRights.FullControl, true);
                //net2tmp_sec = AddAccessRule(net2tmp_sec, "IIS_WPG", FileSystemRights.Read, true);
                _args.Name = "NULL";
                _args.Type = AccessRuleSetType.Appling;
                onSetAccessRuleStatusChange(_args);
                Directory.SetAccessControl(@"C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\Temporary ASP.NET Files", net2tmp_sec);
                _args.Type = AccessRuleSetType.Applied;
                onSetAccessRuleStatusChange(_args);
            }
            catch { }

            try
            {
                _args.FilePath = @"C:\WINDOWS\system32\inetsrv\ASP Compiled Templates";
                DirectorySecurity asptmp_sec = Directory.GetAccessControl(@"C:\WINDOWS\system32\inetsrv\ASP Compiled Templates");
                //asptmp_sec = AddAccessRule(asptmp_sec, "IIS_WPG", FileSystemRights.Read, true);
                asptmp_sec = AddAccessRule(asptmp_sec, "NETWORK", FileSystemRights.FullControl, true);
                _args.Name = "NULL";
                _args.Type = AccessRuleSetType.Appling;
                onSetAccessRuleStatusChange(_args);
                Directory.SetAccessControl(@"C:\WINDOWS\system32\inetsrv\ASP Compiled Templates", asptmp_sec);
                _args.Type = AccessRuleSetType.Applied;
                onSetAccessRuleStatusChange(_args);
            }
            catch { }
            _args.FilePath = "NULL";
            _args.Name = "NULL";
            _args.Type = AccessRuleSetType.Finished;
            _g.LoggerObj.WriteLogLine("(FSE)驱动器C安全过程结束...");
            OnSetAccessRuleStatusChange(this, _args);
            _g.LoggerObj.WriteLogLine("(THR)线程_th_set_thead退出...");
        }
        private void DeleteAccessRule(string identity, string filePath)
        {
            _args.FilePath = filePath;
            _args.Name = "NULL";
            try
            {
                ACL.RemoveAccessRule(filePath, identity);
                _args.Type = AccessRuleSetType.Done;
            }
            catch
            { _args.Type = AccessRuleSetType.Error; }
            OnSetAccessRuleStatusChange(this, _args);
        }
        private void onSetAccessRuleStatusChange(AccessRuleSetArgs args)
        {
            if (OnSetAccessRuleStatusChange != null) OnSetAccessRuleStatusChange(this, args);
            if (args.Type == AccessRuleSetType.Finished) Dispose();
        }
        private DirectorySecurity AddAccessRule(DirectorySecurity ds, string identity, FileSystemRights rights, bool Inhert)
        {
            _args.Name = identity;
            try
            {
                ds = ACL.AddAccessRule(ds, identity, rights, Inhert);
                _args.Type = AccessRuleSetType.Done;
            }
            catch { _args.Type = AccessRuleSetType.Error; }
            OnSetAccessRuleStatusChange(this, _args);
            return ds;
        }
        private void AddProtection(string[] files)
        {
            foreach (string file in files)
            {
                try
                {
                    FileSecurity fs = File.GetAccessControl(file);
                    fs.SetAccessRuleProtection(false, false);
                    fs = ACL.RemoveAllSystemAccessRule(fs);
                    File.SetAccessControl(file, fs);
                }
                catch { }
            }
        }

        #region IDisposable 成员

        public void Dispose()
        {
            try
            {
                if (_t != null)
                {
                    if (_t.ThreadState == ThreadState.Background) _t.Abort();
                }
                this.OnSetAccessRuleStatusChange = null;
                _t = null;
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        #endregion
    }
    delegate void AccessRuleSetHander(object sender, AccessRuleSetArgs e);
    class AccessRuleSetArgs
    {
        public AccessRuleSetType Type;
        public string Name;
        public string FilePath;
    }
    enum AccessRuleSetType
    {
        RemoveAll = 0,
        Done = 1,
        Appling = 2,
        Applied = 3,
        Finished = 4,
        ProcessFile = 5,
        Error = 6
    }
}