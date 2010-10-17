using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SST.Controls
{
    public partial class PlusManagerControl : SST.Controls.MainFormTemplate
    {
        public PlusManagerControl()
        {
            InitializeComponent();
        }

        private void PlusManagerControl_Load(object sender, EventArgs e)
        {

        }

        public void ctlRefreshPlusList_Click(object sender, EventArgs e)
        {
            int i = ctlPlusListBox.SelectedIndex;
            ctlPlusListBox.BeginUpdate();
            ctlPlusListBox.Items.Clear();

            foreach (ObjectClass oc in _g.plusManager.ObjectList)
            {
                ctlPlusListBox.Items.Add(oc.ObjectName);
            }
            if (ctlPlusListBox.Items.Count > i)
                ctlPlusListBox.SelectedIndex = i;
            else
                ctlPlusListBox.SelectedIndex = ctlPlusListBox.Items.Count - 1;
            ctlPlusListBox.EndUpdate();
        }

        private void ctlStopPlus_Click(object sender, EventArgs e)
        {
            if (ctlPlusListBox.SelectedIndex != -1)
            {
                if (_g.plusManager.RemovePlus(ctlPlusListBox.Items[ctlPlusListBox.SelectedIndex].ToString()))
                    MessageBox.Show("²å¼þ" + ctlPlusListBox.Items[ctlPlusListBox.SelectedIndex].ToString() + "ÒÆ³ý³É¹¦£¡", "³É¹¦", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("²å¼þ" + ctlPlusListBox.Items[ctlPlusListBox.SelectedIndex].ToString() + "ÒÆ³ýÊ§°Ü£¡", "Ê§°Ü", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctlRefreshPlusList_Click(this, EventArgs.Empty);
            }
        }

        private void ctlConfigPlusButton_Click(object sender, EventArgs e)
        {
            _g.plusManager.ConfigPlus(ctlPlusListBox.Items[ctlPlusListBox.SelectedIndex].ToString());
        }
    }
}

