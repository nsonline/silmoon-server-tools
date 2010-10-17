using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace SST.Ext.Tools.Classes
{
    class HardFixClass
    {
        public static bool FixWindowsInstallCopyFile()
        {
            try
            {
                Process.Start(@"c:\windows\system32\esentutl.exe", @" /p C:\Windows\security\database\secedit.sdb");
                return true;
            }
            catch { return false; }
        }
    }
}