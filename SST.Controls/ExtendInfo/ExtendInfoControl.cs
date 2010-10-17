using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SST.Controls.ExtendInfo
{
    public partial class ExtendInfoControl : UserControl
    {
        PerformanceCounter _iisPerf_Total;
        PerformanceCounter _iisPerf_Sent;
        PerformanceCounter _iisPerf_Received;
        Timer _timer = new Timer();
        public ExtendInfoControl()
        {
            InitializeComponent();
            _timer.Interval = 3000;
            _timer.Tick += new EventHandler(_timer_Tick);
        }
        public bool StartControl()
        {
            try
            {
                panel1.Visible = true;
                _iisPerf_Total = new PerformanceCounter("Web Service", "Total Bytes Transfered", "_Total");
                _iisPerf_Sent = new PerformanceCounter("Web Service", "Total Bytes Sent", "_Total");
                _iisPerf_Received = new PerformanceCounter("Web Service", "Total Bytes Received", "_Total");
                _timer.Start();
                return true;
            }
            catch (Exception ex)
            {
                ctlIISPerfText.Text = "(错误):" + ex.Message;
                return false;
            }
        }
        public void StopControl()
        {
            _timer.Stop();
            _iisPerf_Total.Close();
            _iisPerf_Sent.Close();
            _iisPerf_Received.Close();
            panel1.Visible = false;
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            ctlIISPerfText.Text = "发送 " + uLongToTextMb((ulong)_iisPerf_Sent.NextValue()) +
                ",接收 " + uLongToTextMb((ulong)_iisPerf_Received.NextValue()) + ",总量 " +
                uLongToTextMb((ulong)_iisPerf_Total.NextValue());
        }
        string uLongToTextMb(ulong i)
        {
            ulong KB = ((ulong)(i / 1024));
            if (KB < 1048576)
                return KB + " Kb";
            else if (KB < 1073741824)
                return ((float)(KB / 1024)) + " Mb";
            else
                return ((float)(KB / 1048576)) + " Gb";
        }

        private void ctlStartControlLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ctlStartControlLinkButton.Text == "启动")
                {
                    if (StartControl())
                        ctlStartControlLinkButton.Text = "停止";
                }
                else
                {
                    StopControl();
                    ctlStartControlLinkButton.Text = "启动";
                }
            }
        }
    }
}
