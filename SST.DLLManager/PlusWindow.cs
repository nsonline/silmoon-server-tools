using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SST.DLLManager
{
    public partial class PlusWindow : Form
    {
        GBC _g;
        public PlusWindow(GBC g)
        {
            _g = g;
            InitializeComponent();
            Show();
        }

        private void PlusWindow_Load(object sender, EventArgs e)
        {
            RefreshPlusList();
        }

        private void RefreshPlusList()
        {
            if (!File.Exists(_g.Pathinfo.PlusConfig)) return;
            string[] LineArr = File.ReadAllLines(_g.Pathinfo.PlusConfig);
            foreach (string Line in LineArr)
            {
                string[] lineSplit = Line.Split(new string[] { "|" }, StringSplitOptions.None);
                ctlPluslv.Items.Add(new ListViewItem(new string[] { lineSplit[0].Replace("{AppRoot}\\",""), lineSplit[1], lineSplit[2], lineSplit[3] }));
            }
        }
    }
}