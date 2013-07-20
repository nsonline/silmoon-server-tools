using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Windows.Forms;
using Silmoon;
using System.IO;

namespace SST.Client.Classes
{
    class MainFormHelper
    {
        GBC _g;
        MainForm mf;

        public MainFormHelper(GBC g)
        {
            _g = g;
            mf = ((MainForm)_g.MainForm);
        }
        public void InitMainFormComponent()
        {
            DrawMainForm();
            DrawFormFromConfigFile();
        }
        public void MainFormShowed()
        {
            _g.EverySecondEvent += new EventHandler(_g_EverySecondEvent);
            new OnShownRun(_g);
        }
        void _g_EverySecondEvent(object sender, EventArgs e)
        {
            mf.Invoke(new Action<int>((int i) =>
            {
                mf.C_TimeLabel.Text = DateTime.Now.ToString();
            }), 0);
        }
        void DrawMainForm()
        {
            try
            {
                mf.ctlmMainFornWebBrowser.Url = new Uri(_g.RConfigIni.ReadInivalue("Config", "MainFormWebBrowser"));
            }
            catch { }
        }
        void DrawFormFromConfigFile()
        {
            if (SmString.StringToBool(_g.Cfg.ReadConfig("ShowToolBar")))
                mf.¹¤¾ßÀ¸TToolStripMenuItem_Click(this, EventArgs.Empty);
        }
    }
}
