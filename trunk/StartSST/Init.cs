using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StartSST
{
    public partial class Init : Form
    {
        Timer _t = new Timer();
        public Init()
        {
            InitializeComponent();
            _t.Tick += new EventHandler(_t_Tick);
            _t.Start();
        }

        void _t_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void Init_Shown(object sender, EventArgs e)
        {
            _t.Start();
        }

        private void Init_FormClosed(object sender, FormClosedEventArgs e)
        {
            _t.Dispose();
        }
    }
}