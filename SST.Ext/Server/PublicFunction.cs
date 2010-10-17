using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace SST.Ext.Server
{
    public class ToolFunctions
    {
        public ToolFunctions()
        {

        }
        public static void FixRdpclip()
        {
            Process[] procArr = Process.GetProcessesByName("rdpclip");
            foreach (Process p in procArr)
            {
                if (p.ProcessName.ToLower() == "rdpclip") p.Kill();
            }
            Process.Start("rdpclip");
        }
    }
}