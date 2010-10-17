using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SST.Client.Window
{
    public partial class FirstWelcome : Form
    {
        GBC _g;
        public FirstWelcome(GBC g)
        {
            _g = g;
            InitializeComponent();
            ShowDialog();
        }
    }
}