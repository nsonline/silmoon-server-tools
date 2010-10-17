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
                _g.LoggerObj.WriteLogLine("WSHom.Ocx��ж�ء�", 0);
                Process.Start("regsvr32", "shell32.dll /u /s");
                _g.LoggerObj.WriteLogLine("shell32.dll��ж�ء�", 0);
                Process.Start("regsvr32", "wshext.dll /u /s");
                _g.LoggerObj.WriteLogLine("wshext.dll��ж�ء�", 0);

                _g.LoggerObj.WriteLogLine("(SEC)��Σ����ѱ�ж��", 10);
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        public void InstallUnSecurityMobule()
        {
            try
            {
                Process.Start("regsvr32", "WSHom.Ocx /s");
                _g.LoggerObj.WriteLogLine("WSHom.Ocx��ע�ᡣ", 0);
                Process.Start("regsvr32", "shell32.dll /s");
                _g.LoggerObj.WriteLogLine("shell32.dll��ע�ᡣ", 0);
                Process.Start("regsvr32", "wshext.dll /s");
                _g.LoggerObj.WriteLogLine("wshext.dll��ע�ᡣ", 0);

                _g.LoggerObj.WriteLogLine("(SEC)��Σ�����ע�������!!!", 10);
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
                    _g.LoggerObj.WriteLogLine("��ж�ط�ARP��������...");
                    MessageBox.Show("�ɹ��������Ӧ�Ĳ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("û�з��ַ�ARP��ز����ż��������������ֹ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
                    _g.LoggerObj.WriteLogLine("��ִ�з�ARP��������...");
                    MessageBox.Show("�ɹ��������Ӧ�Ĳ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("���ַ�ARP��ز����Ѿ�ִ�У���������ֹ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        #region IDisposable ��Ա

        public void Dispose()
        {

        }

        #endregion
    }
}
