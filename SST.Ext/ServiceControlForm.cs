using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using Silmoon.Service;

namespace SST.Ext
{
    public partial class ServiceControlForm : Form
    {
        GBC _g;
        string _serviceName;
        ServiceController _sc;
        
        public ServiceControlForm(GBC g, string serviceName)
        {
            _g = g;
            _serviceName = serviceName;
            _g.ServiceCtrl.OnServiceStateChange += new SmServiceEventHandler(ServiceCtrl_OnServiceStateChange);
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            this.FormClosed += new FormClosedEventHandler(ServiceControlForm_FormClosed);
            Show();
        }
        void ServiceControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _g.ServiceCtrl.OnServiceStateChange -= new SmServiceEventHandler(ServiceCtrl_OnServiceStateChange);
            Dispose(true);
        }
        void ServiceCtrl_OnServiceStateChange(object sender, SmServiceEventArgs e)
        {
            this.Text = "������ƣ�" + _serviceName + "(" + e.CompleteState.ToString() + "-" + e.ServiceOption.ToString() + ")";
            if (e.Error != null)
                MessageBox.Show(e.Error.ToString(), "�����쳣");
            try
            {
                RefreshControl();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ServiceControlForm_Load(object sender, EventArgs e)
        {
            if (ServiceControl.IsExisted(_serviceName))
            {
                _sc = new ServiceController(_serviceName);
                _sc.Refresh();
                RefreshControl();
                this.Text = "������ƣ�" + _serviceName;
            }
            else
            {
                MessageBox.Show("���񲻴���");
                C_RunStatus.Text = "������";
                C_SetStatus.Text = "������";
            }
        }

        private void RefreshControl()
        {
            if (_sc != null)
                _sc.Refresh();
            if (ServiceControl.GetRunType(_serviceName) != ServiceStartType.Disabled)
            {
                switch (_sc.Status)
                {
                    case ServiceControllerStatus.Running:
                        C_11.Enabled = false;
                        C_12.Enabled = true;
                        C_13.Enabled = true;
                        C_RunStatus.Text = "������";
                        break;
                    case ServiceControllerStatus.Stopped:
                        C_11.Enabled = true;
                        C_12.Enabled = false;
                        C_13.Enabled = false;
                        C_RunStatus.Text = "��ֹͣ";
                        break;
                    default:
                        break;
                }
                switch (ServiceControl.GetRunType(_serviceName))
                {
                    case ServiceStartType.Automatic:
                        C_21.Enabled = false;
                        C_22.Enabled = true;
                        C_23.Enabled = true;
                        C_SetStatus.Text = "�Զ�����";
                        break;
                    case ServiceStartType.Manual:
                        C_21.Enabled = true;
                        C_22.Enabled = false;
                        C_23.Enabled = true;
                        C_SetStatus.Text = "�ֶ�����";
                        break;
                    default:
                        break;
                }
            }
            else if (ServiceControl.GetRunType(_serviceName) == ServiceStartType.Automatic)
            {
                C_21.Enabled = false;
                C_22.Enabled = true;
                C_23.Enabled = true;
                C_SetStatus.Text = "�Զ�����";
            }
            else if (ServiceControl.GetRunType(_serviceName) == ServiceStartType.Manual)
            {
                C_21.Enabled = true;
                C_22.Enabled = false;
                C_23.Enabled = true;
                C_SetStatus.Text = "�ֶ�����";
            }
            else
            {
                C_11.Enabled = false;
                C_12.Enabled = false;
                C_13.Enabled = false;
                C_21.Enabled = true;
                C_22.Enabled = true;
                C_23.Enabled = false;
                C_SetStatus.Text = "�ѽ���";
            }
        }

        private void C_11_Click(object sender, EventArgs e)
        {
            _g.ServiceCtrl.AsyncService(_serviceName, ServiceOptions.Start);
            RefreshControl();
        }
        private void C_12_Click(object sender, EventArgs e)
        {
            _g.ServiceCtrl.AsyncService(_serviceName, ServiceOptions.Stop);
            RefreshControl();
        }
        private void C_13_Click(object sender, EventArgs e)
        {
            _g.ServiceCtrl.AsyncService(_serviceName, ServiceOptions.Reset);
            RefreshControl();
        }
        private void C_21_Click(object sender, EventArgs e)
        {
            ServiceControl.SetRunType(ServiceStartType.Automatic, _serviceName);
            RefreshControl();
        }
        private void C_22_Click(object sender, EventArgs e)
        {
            ServiceControl.SetRunType(ServiceStartType.Manual, _serviceName);
            RefreshControl();
        }
        private void C_23_Click(object sender, EventArgs e)
        {
            ServiceControl.SetRunType(ServiceStartType.Disabled, _serviceName);
            RefreshControl();
        }
    }
}