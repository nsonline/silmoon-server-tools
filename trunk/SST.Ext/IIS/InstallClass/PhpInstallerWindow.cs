using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SST.Ext.IIS
{
    public partial class PhpInstallerWindow : Form
    {
        public PhpInstallerWindow()
        {
            InitializeComponent();
        }

        private void PhpInstallerWindow_Load(object sender, EventArgs e)
        {

        }

        private void PhpInstallerWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }
    }
}