using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Threading;
using Silmoon.IO.SmFile;
using SST.Common;

namespace SST.Ext.Security
{
    class ModuleSecuritySettingsClass:IDisposable
    {
        GBC _g;

        public ModuleSecuritySettingsClass(GBC g)
        {
            _g = g;
            
        }
        public void UninstallUnSecurityMobule()
        {
            try
            {
                Process.Start("regsvr32", "WSHom.Ocx /u /s");
                _g.LoggerObj.WriteLogLine("WSHom.Ocx被卸载。", 0);
                Process.Start("regsvr32", "shell32.dll /u /s");
                _g.LoggerObj.WriteLogLine("shell32.dll被卸载。", 0);
                Process.Start("regsvr32", "wshext.dll /u /s");
                _g.LoggerObj.WriteLogLine("wshext.dll被卸载。", 0);

                _g.LoggerObj.WriteLogLine("(SEC)高危组件已被卸载", 10);
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        public void InstallUnSecurityMobule()
        {
            try
            {
                Process.Start("regsvr32", "WSHom.Ocx /s");
                _g.LoggerObj.WriteLogLine("WSHom.Ocx被注册。", 0);
                Process.Start("regsvr32", "shell32.dll /s");
                _g.LoggerObj.WriteLogLine("shell32.dll被注册。", 0);
                Process.Start("regsvr32", "wshext.dll /s");
                _g.LoggerObj.WriteLogLine("wshext.dll被注册。", 0);

                _g.LoggerObj.WriteLogLine("(SEC)高危组件被注册服务器!!!", 10);
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        public void InstallAntiARP()
        {
            Thread _th_instArp = new Thread(_th_proc_InstallAntiARP);
            _th_instArp.IsBackground = true;
            _th_instArp.Start();
        }
        public void UninstallAntiARP()
        {
            try
            {
                if (File.Exists(@"C:\WINDOWS\System32\drivers\npf.sys")) File.Delete(@"C:\WINDOWS\System32\drivers\npf.sys");

                if (CommonFunctions.deleteUndeleteFile(@"C:\WINDOWS\System32\drivers\npf.sys", ref _g))
                {
                    _g.LoggerObj.WriteLogLine("已卸载防ARP病毒过程...");
                    MessageBox.Show("成功完成所相应的操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("没有发现防ARP相关操作遗迹，反向操作已终止！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        private void _th_proc_InstallAntiARP()
        {
            try
            {
                if (File.Exists(@"C:\WINDOWS\System32\drivers\npf.sys")) File.Delete(@"C:\WINDOWS\System32\drivers\npf.sys");

                if (CommonFunctions.createUndeleteFile(@"C:\WINDOWS\System32\drivers\npf.sys", ref _g))
                {
                    _g.LoggerObj.WriteLogLine("已执行防ARP病毒过程...");
                    MessageBox.Show("成功完成所相应的操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("发现防ARP相关操作已经执行，操作已终止！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        #region IDisposable 成员

        public void Dispose()
        {

        }

        #endregion
    }
}
