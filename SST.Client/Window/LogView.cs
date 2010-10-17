using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SST.Client.Window
{
    public partial class LogView : Form
    {
        GBC _g;
        public LogView(GBC g)
        {
            _g = g;
            _g.LoggerObj.OnLogRecording += new LogEventHander(LoggerObj_OnLogRecording);
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
        }

        void LoggerObj_OnLogRecording(string[] logArr, string newLine, int logLevel)
        {
            if (logLevel > 5)
                listBox1.Items.Insert(0, "[" + DateTime.Now.ToString() + "]:" + newLine);
        }
        private void LogView_Load(object sender, EventArgs e)
        {
            foreach (object logObj in _g.LoggerObj.StringLogArray)
            {
                listBox1.Items.Insert(0, logObj.ToString());
            }
        }

        private void LogView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _g.LoggerObj.OnLogRecording -= new LogEventHander(LoggerObj_OnLogRecording);
            Dispose(true);
        }
    }
}