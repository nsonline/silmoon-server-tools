using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Windows.Server.IIS;

namespace SST.Ext.IIS
{
    public partial class BindingsListForm : Form
    {
        IISManager _iisMgr;
        public BindingsListForm(IISManager iisMgr)
        {
            _iisMgr = iisMgr;
            InitializeComponent();
        }
        void RefreshBindings()
        {
            Text = "IIS�󶨹���...ˢ����Ϣ";
            WebSiteBaseInfo[] websiteArray = _iisMgr.WebSiteList;
            foreach (WebSiteBaseInfo websitebaseinfo in websiteArray)
            {
                WebSiteInfo info = _iisMgr.GetWebsiteInfo(websitebaseinfo.SiteID);
                string[] bindingsArray = IISManager.GetIISConfigObjectArray(info.Bindings);
                foreach (string bindingString in bindingsArray)
                {
                    string[] param = bindingString.Split(new string[] { ":" }, StringSplitOptions.None);
                    ctlBindingsListView.Items.Add(new ListViewItem(new string[] { websitebaseinfo.SiteName, param[2], param[1], param[0] }));
                }
            }
            Text = "IIS�󶨹���";
        }

        private void BindingsListForm_Shown(object sender, EventArgs e)
        {
            RefreshBindings();
        }
    }
}