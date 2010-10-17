using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Silmoon.IO.SmFile;

namespace SST.Common
{
    public class CommonFunctions
    {
        public static bool createUndeleteFile(string filePath, ref GBC g)
        {
            try
            {
                if (Directory.Exists(filePath)) return false;

                Directory.CreateDirectory(filePath);
                DirectoryInfo d = new DirectoryInfo(filePath);
                d.Attributes = FileAttributes.Hidden;
                d.Refresh();
                
                int i = new Random().Next(1000, 9999);
                File.WriteAllText(g.Pathinfo.SysTempDir + "tmp" + i.ToString() + ".bat", "cd " + Path.GetFileName(filePath) + "\r\nmd a..\\");

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.WorkingDirectory = Path.GetDirectoryName(filePath);
                psi.FileName = g.Pathinfo.SysTempDir + "tmp" + i.ToString() + ".bat";
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(psi);
                psi = null;
                Thread.Sleep(500);
                ACL.RemoveAllSystemAccessRule(filePath);
                ACL.SetProtectionRule(filePath, true, false);
                return true;
            }
            catch (Exception ex) { g.ProtectRunAsClass(ex.ToString()); return false; }
        }
        public static bool deleteUndeleteFile(string filePath, ref GBC g)
        {
            try
            {
                if (!Directory.Exists(filePath)) return false;

                ACL.AddAccessRule(filePath, "administrators");
                ACL.SetProtectionRule(filePath, false, false);

                int i = new Random().Next(1000, 9999);
                File.WriteAllText(g.Pathinfo.SysTempDir + "tmp" + i.ToString() + ".bat", "cd " + Path.GetFileName(filePath) + "\r\nrd a..\\\r\ncd ..\r\nrd " + Path.GetFileName(filePath) + "");

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.WorkingDirectory = Path.GetDirectoryName(filePath);
                psi.FileName = g.Pathinfo.SysTempDir + "tmp" + i.ToString() + ".bat";
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(psi);
                psi = null;
                return true;
            }
            catch (Exception ex) { g.ProtectRunAsClass(ex.ToString()); return false; }
        }
    }
}