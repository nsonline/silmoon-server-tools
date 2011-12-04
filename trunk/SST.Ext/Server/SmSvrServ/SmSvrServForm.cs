using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Service;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.IO;
using Silmoon;
using System.ServiceProcess;
using Silmoon.Configure;

namespace SST.Ext.Server.SmSvrServ
{
    public partial class SmSvrServForm : Form
    {
        GBC _g;
        ServiceController cs;
        Silmoon.Security.CSEncrypt sce = new Silmoon.Security.CSEncrypt();
        public SmSvrServForm(GBC g)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            _g = g;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            _g.ServiceCtrl.OnServiceStateChange += new SmServiceEventHandler(ServiceCtrl_OnServiceStateChange);
            if (ServiceControl.IsExisted("SmSvrServ"))
                cs = new ServiceController("SmSvrServ");
            Show();
        }

        void ServiceCtrl_OnServiceStateChange(object sender, SmServiceEventArgs e)
        {
            if (cs != null)
            {
                cs.Refresh();
                try
                {
                    switch (cs.Status)
                    {
                        case ServiceControllerStatus.Paused:
                            ServiceStatus.Text = "服务暂停";
                            break;
                        case ServiceControllerStatus.Running:
                            ServiceStatus.Text = "服务运行中";
                            break;
                        case ServiceControllerStatus.Stopped:
                            ServiceStatus.Text = "服务停止";
                            break;
                        default:
                            break;
                    }

                }
                catch { ServiceStatus.Text = "未安装"; }
            }
        }
        private void SilmoonServices_Load(object sender, EventArgs e)
        {
            DrawForm();
            FillText();
        }

        private void FillText()
        {
            if (File.Exists(@"c:\windows\system32\SmSvrServ.ini"))
            {
                IniFile ini = new IniFile(@"c:\windows\system32\SmSvrServ.ini");

                svcLocalIP.Text = ini.ReadInivalue("Server", "LocalIP");
                svcGatewayIP.Text = ini.ReadInivalue("Server", "GateWayIP");
                svcGatewayMAC.Text = ini.ReadInivalue("Server", "GateMAC");
                svcBindARPEnable.Checked = SmString.StringToBool(ini.ReadInivalue("Server", "BindMAC"));

                svcDetectSleep.Text = ini.ReadInivalue("Server", "DetectSleep");
                svcDetectEnable.Checked = SmString.StringToBool(ini.ReadInivalue("Server", "DetectEnable"));

                netCmdPort.Text = ini.ReadInivalue("Server", "NetCmdPort");
                netCmdPwd.Text = sce.Decrypt(ini.ReadInivalue("Server", "NetCmdPassword"));
                netCmdEnable.Checked = SmString.StringToBool(ini.ReadInivalue("Server", "NetCmdEnable"));

                rdpPortFixEnable.Checked = SmString.StringToBool(ini.ReadInivalue("Server", "FixRDPPort"));
                rdpConnectFixEnable.Checked = SmString.StringToBool(ini.ReadInivalue("Server", "FixRDPConnection"));
            }
        }

        private void DrawForm()
        {
            UninstallButton.Text = "卸载服务(&U)";
            if (!ServiceControl.IsExisted("SmSvrServ"))
            {
                ApplyButton.Text = "安装服务(&I)";
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                SettingService.Enabled = false;
                UninstallButton.Enabled = false;
            }
            else
            {
                ApplyButton.Text = "应用(&A)";
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                SettingService.Enabled = true;
                UninstallButton.Enabled = true;
            }
            ServiceCtrl_OnServiceStateChange(this, null);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ApplyButton.Text == "安装服务(&I)")
                {
                    if (ServiceControl.IsExisted("smservr"))
                    {
                        MessageBox.Show("请先删除旧版服务!");
                        return;
                    }
                    if (MessageBox.Show("安装 银月服务器服务(SmSvrServ)？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ApplyButton.Text = "安装中..1";
                        ApplyButton.Enabled = false;
                        DownloadAndRun installer = new DownloadAndRun(_g, _g.Pathinfo.RemoteSSTFile + "SmSvrServ.exe", "SmSvrServ.exe", false);
                        installer.OnDownloadCompleted += new AsyncCompletedEventHandler(installer_OnDownloadCompleted);
                        installer.OnProcessExit += new EventHandler(installer_OnProcessExit);
                        installer.Start();
                    }
                }
                else
                {
                    try
                    {
                        if (File.Exists(@"c:\windows\system32\SmSvrServ.ini"))
                        {
                            IniFile ini = new IniFile(@"c:\windows\system32\SmSvrServ.ini");

                            if (CheckIPFormat(svcLocalIP.Text)) ini.WriteInivalue("Server", "LocalIP", svcLocalIP.Text); else return;
                            if (CheckIPFormat(svcGatewayIP.Text)) ini.WriteInivalue("Server", "GateWayIP", svcGatewayIP.Text); else return;
                            if (!IsEmpty(svcGatewayMAC.Text)) ini.WriteInivalue("Server", "GateMAC", svcGatewayMAC.Text); else return;
                            ini.WriteInivalue("Server", "BindMAC", svcBindARPEnable.Checked.ToString());

                            ini.WriteInivalue("Server", "DetectSleep", int.Parse(svcDetectSleep.Text).ToString());
                            ini.WriteInivalue("Server", "DetectEnable", svcDetectEnable.Checked.ToString());

                            if (!IsEmpty(netCmdPwd.Text)) ini.WriteInivalue("Server", "NetCmdPassword", sce.Encrypt(netCmdPwd.Text)); else return;
                            ini.WriteInivalue("Server", "NetCmdPort", SmInt.CheckIntValue(int.Parse(netCmdPort.Text), 1, 65535, true).ToString());
                            ini.WriteInivalue("Server", "NetCmdEnable", netCmdEnable.Checked.ToString());

                            ini.WriteInivalue("Server", "FixRDPPort", rdpPortFixEnable.Checked.ToString());
                            ini.WriteInivalue("Server", "FixRDPConnection", rdpConnectFixEnable.Checked.ToString());

                            MessageBox.Show("配置保存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ServiceControl.SetRunType(ServiceStartType.Automatic, "SmSvrServ");
                        }
                    }
                    catch (Exception ex) { _g.PopErrorMessage(ex.ToString()); }
                }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        private void SettingService_Click(object sender, EventArgs e)
        {
            new ServiceControlForm(_g, "SmSvrServ");
        }
        private void UninstallButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("卸载 银月服务器服务(SmSvrServ)？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                UninstallButton.Enabled = false;
                UninstallButton.Text = "卸载中...";
                try
                {
                    Process uninstall_p = new Process();
                    uninstall_p.StartInfo.FileName = @"c:\windows\system32\installutil.exe";
                    uninstall_p.StartInfo.Arguments = @" ""C:\WINDOWS\system32\SmSvrServ.exe"" /u";
                    uninstall_p.StartInfo.WorkingDirectory = @"c:\windows\system32\";
                    uninstall_p.EnableRaisingEvents = true;
                    uninstall_p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    uninstall_p.Exited += new EventHandler(uninstall_p_Exited);
                    uninstall_p.Start();
                }
                catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); DrawForm(); }
            }
        }
        #region 安装和卸载过程
        void installer_OnDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            ApplyButton.Text = "安装中..2";
            if (e.Error != null)
            {
                _g.PopErrorMessage(e.Error.Message);
                _g.LoggerObj.WriteLogLine("(SVC)银月服务文件同步错误...");
            }
            else
            {
                _g.LoggerObj.WriteLogLine("(SVC)银月服务文件同步完成...");
                //DrawForm();
            }
        }
        void installer_OnProcessExit(object sender, EventArgs e)
        {
            try
            {
                Process install_p = new Process();
                install_p.StartInfo.FileName = @"c:\windows\system32\installutil.exe";
                install_p.StartInfo.Arguments = @" C:\WINDOWS\system32\SmSvrServ.exe";
                install_p.EnableRaisingEvents = true;
                install_p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                install_p.Exited += new EventHandler(install_p_Exited);
                install_p.Start();
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        void install_p_Exited(object sender, EventArgs e)
        {
            try
            {
                if (ServiceControl.IsExisted("SmSvrServ"))
                {
                    MessageBox.Show("安装成功！\r\n\r\n请配置好后使用 服务控制 启动服务！\r\n设置完后点击应用会设置为自动启动！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _g.LoggerObj.WriteLogLine("(SVC)服务成功安装!");
                    if (cs == null) cs = new ServiceController("SmSvrServ");
                    _g.StatusLabel.Text = "银月服务(SmSvrServ)被安装...";
                    if (File.Exists(Application.StartupPath + "\\InstallUtil.InstallLog")) File.Delete(Application.StartupPath + "\\InstallUtil.InstallLog");
                    ServiceControl.SetRunType(ServiceStartType.Disabled, "SmSvrServ");
                    FillText();
                }
                else
                {
                    MessageBox.Show("安装失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _g.LoggerObj.WriteLogLine("(SVC)服务安装失败!");
                }
                DrawForm();
                ((Process)sender).Exited -= new EventHandler(install_p_Exited);
                ((Process)sender).Dispose();
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
            ApplyButton.Enabled = true;
        }
        void uninstall_p_Exited(object sender, EventArgs e)
        {
            _g.LoggerObj.WriteLogLine("(SVC)服务被卸载安装!");
            DrawForm();
            _g.StatusLabel.Text = "银月服务(SmSvrServ)被卸载...";
            if (File.Exists(Application.StartupPath + "\\InstallUtil.InstallLog")) File.Delete(Application.StartupPath + "\\InstallUtil.InstallLog");
            MessageBox.Show("卸载完成.", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((Process)sender).Exited -= new EventHandler(uninstall_p_Exited);
            ((Process)sender).Dispose();
        }
        #endregion

        private void SilmoonServices_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cs != null) cs.Dispose();
            _g.ServiceCtrl.OnServiceStateChange -= new SmServiceEventHandler(ServiceCtrl_OnServiceStateChange);
            Dispose(true);
        }
        private void AutoWrite_Click(object sender, EventArgs e)
        {
            svcLocalIP.Text = _g.serverInfo.LocalIP[0].ToString();
            svcGatewayIP.Text = _g.serverInfo.GatewayIP.ToString();
            svcGatewayMAC.Text = _g.serverInfo.GatewayMAC;
        }
        private void svcBindARPEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (svcBindARPEnable.Checked) MessageBox.Show("要使用绑定ARP不受ARP攻击影响的话\r\n您必须保证你填写的网关ip和网关mac正确！\r\n否则会断线，建议使用[自动填写]，\r\n但是要确认一下正确性！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        bool CheckIPFormat(string ipstr)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(ipstr);
                return true;
            }
            catch (Exception ex) { _g.PopErrorMessage(ex.Message); return false; }
        }
        bool IsEmpty(string s)
        {
            bool rebool = true;
            if (s == "" || s == null) { throw new ArgumentException("参数不能为空！"); }
            else { rebool = false; }
            return rebool;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Process.Start("http://www.silmoon.com.cn/cn/articleinfo/detail_7_36_99.html");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Process.Start("http://www.silmoon.com.cn/cn/articleinfo/detail_5_38_103.html");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new OldServiceForm(_g).ShowDialog();
        }
    }
}