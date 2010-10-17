using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Timers;
using Silmoon.Windows.Systems;
using Silmoon;

namespace SST.Controls
{
    public partial class MainForm_Info : UserControl
    {
        public GBC _g;
        
        System.Timers.Timer _timer = new System.Timers.Timer();
        DriveInfo _cDriverInfo = new DriveInfo("c");
        SystemInfo _sysInfo = new SystemInfo();
        string _cDirverTotalSpace = "0";
        double _memoryTotalSize = 0;

        public event EventHandler OnClickIpListLink;
        int _timerCount = 3;

        public MainForm_Info()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        public void StartControl(GBC g)
        {
            _g = g;
            _timer.Interval = 1000;
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            DrawControl();
        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (_timerCount > 2)
                {
                    _timerCount = 1;
                    ctlCDriverSpaceLabel.Text = SmString.CutString(((double)_cDriverInfo.TotalFreeSpace / 1073741824).ToString(), 5) + "Gb/" + _cDirverTotalSpace + "Gb";
                }
                else _timerCount++;
                ctlProcessorTimeLabel.Text = _sysInfo.CPULoadPercentage + "%";
                MEMORY_INFO memInfo = _sysInfo.GetMemoryInfo;
                ctlMemoryStatLabel.Text = SmString.CutString(((double)memInfo.dwAvailPhys / 1073741824).ToString(), 5) + "Gb/" + SmString.CutString((_memoryTotalSize).ToString(), 5) + "Gb";
            }
            catch { }
        }

        private void DrawControl()
        {
            ctlServerNameLabel.Text = Dns.GetHostName();
            ctlIPAddressLabel.Text = _g.serverInfo.WanIP.ToString();
            foreach (IPAddress ip in _g.serverInfo.LocalIP)
            {
                if (ip.ToString().Contains(":"))
                    continue;
                ctlCIPLinkButton.Text = ip.ToString();
                break;
            }
            _cDirverTotalSpace = SmString.CutString(((double)_cDriverInfo.TotalSize / 1073741824).ToString(), 5);
            _memoryTotalSize = ((double)_sysInfo.GetMemoryInfo.dwTotalPhys) / 1073741824;

            string osVersion = Environment.OSVersion.VersionString;
            string osString = "";
            if (osVersion.IndexOf(" 5.0") != -1)
                osString = "Windows 2000";
            else if (osVersion.IndexOf(" 5.1") != -1)
                osString = "Windows Xp";
            else if (osVersion.IndexOf(" 5.2") != -1)
                osString = "Windows 2003";
            else if (osVersion.IndexOf(" 6.0") != -1)
                osString = "Windows 6";
            else
                osString = "Windows";
            ctlmg2IntrolText.Text = osString;

            string networkTypeString = "";
            if (ctlCIPLinkButton.Text == "127.0.0.1")
                networkTypeString = " 未知服务器";
            else
            {
                networkTypeString = " 内网服务器";
                foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
                {
                    if (ip.ToString() == ctlIPAddressLabel.Text)
                    {
                        networkTypeString = " 公网服务器";
                        break;
                    }
                }
            }
            ctlmg2IntrolText.Text += " " + networkTypeString;

            _timer.Start();
        }

        private void ctlmg2CIPLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (OnClickIpListLink != null) OnClickIpListLink(this, e);
        }
    }
}
