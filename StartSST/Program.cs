using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace Start
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
                //Process[] pArr = Process.GetProcesses();
                //int pc = 0;
                //foreach (Process p in pArr)
                //{
                //    if (p.ProcessName == Process.GetCurrentProcess().ProcessName)
                //    {
                //        pc++;
                //        if (pc == 2)
                //        {
                //            MessageBox.Show("已经有一个实例在运行了！");
                //            Environment.Exit(0);
                //        }
                //    }
                //}
                //Application.EnableVisualStyles();
                //Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;
                Application.SetCompatibleTextRenderingDefault(false);
                //try
                //{
                Application.Run(new StartSST.Init());
                Application.Run(new SST.Client.InitForm());
                //}
                //catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}