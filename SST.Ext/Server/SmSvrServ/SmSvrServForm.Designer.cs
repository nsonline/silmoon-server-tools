namespace SST.Ext.Server.SmSvrServ
{
    partial class SmSvrServForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ApplyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdpConnectFixEnable = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rdpPortFixEnable = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.netCmdEnable = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.netCmdPwd = new System.Windows.Forms.TextBox();
            this.netCmdPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.svcDetectEnable = new System.Windows.Forms.CheckBox();
            this.svcDetectSleep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.svcBindARPEnable = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.svcGatewayMAC = new System.Windows.Forms.TextBox();
            this.svcGatewayIP = new System.Windows.Forms.TextBox();
            this.svcLocalIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoWrite = new System.Windows.Forms.Button();
            this.UninstallButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SettingService = new System.Windows.Forms.Button();
            this.ServiceStatus = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(307, 340);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(93, 23);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "应用(&A)";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdpConnectFixEnable);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.rdpPortFixEnable);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.netCmdEnable);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.netCmdPwd);
            this.groupBox1.Controls.Add(this.netCmdPort);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.svcDetectEnable);
            this.groupBox1.Controls.Add(this.svcDetectSleep);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.svcBindARPEnable);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.svcGatewayMAC);
            this.groupBox1.Controls.Add(this.svcGatewayIP);
            this.groupBox1.Controls.Add(this.svcLocalIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置服务所需要的参数信息";
            // 
            // rdpConnectFixEnable
            // 
            this.rdpConnectFixEnable.AutoSize = true;
            this.rdpConnectFixEnable.Location = new System.Drawing.Point(95, 289);
            this.rdpConnectFixEnable.Name = "rdpConnectFixEnable";
            this.rdpConnectFixEnable.Size = new System.Drawing.Size(84, 16);
            this.rdpConnectFixEnable.TabIndex = 26;
            this.rdpConnectFixEnable.Text = "启用修复？";
            this.rdpConnectFixEnable.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "远程桌面修复：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "RDP 端口修复：";
            // 
            // rdpPortFixEnable
            // 
            this.rdpPortFixEnable.AutoSize = true;
            this.rdpPortFixEnable.Location = new System.Drawing.Point(95, 262);
            this.rdpPortFixEnable.Name = "rdpPortFixEnable";
            this.rdpPortFixEnable.Size = new System.Drawing.Size(84, 16);
            this.rdpPortFixEnable.TabIndex = 23;
            this.rdpPortFixEnable.Text = "启用修复？";
            this.rdpPortFixEnable.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(156, 236);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 12);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "客户端下载";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // netCmdEnable
            // 
            this.netCmdEnable.AutoSize = true;
            this.netCmdEnable.Location = new System.Drawing.Point(95, 235);
            this.netCmdEnable.Name = "netCmdEnable";
            this.netCmdEnable.Size = new System.Drawing.Size(60, 16);
            this.netCmdEnable.TabIndex = 19;
            this.netCmdEnable.Text = "启用？";
            this.netCmdEnable.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "启用远程管理：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "远程管理端口：";
            // 
            // netCmdPwd
            // 
            this.netCmdPwd.Location = new System.Drawing.Point(95, 206);
            this.netCmdPwd.Name = "netCmdPwd";
            this.netCmdPwd.Size = new System.Drawing.Size(120, 21);
            this.netCmdPwd.TabIndex = 15;
            // 
            // netCmdPort
            // 
            this.netCmdPort.Location = new System.Drawing.Point(96, 179);
            this.netCmdPort.Name = "netCmdPort";
            this.netCmdPort.Size = new System.Drawing.Size(120, 21);
            this.netCmdPort.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "远程管理密码：";
            // 
            // svcDetectEnable
            // 
            this.svcDetectEnable.AutoSize = true;
            this.svcDetectEnable.Location = new System.Drawing.Point(95, 157);
            this.svcDetectEnable.Name = "svcDetectEnable";
            this.svcDetectEnable.Size = new System.Drawing.Size(60, 16);
            this.svcDetectEnable.TabIndex = 12;
            this.svcDetectEnable.Text = "启用？";
            this.svcDetectEnable.UseVisualStyleBackColor = true;
            // 
            // svcDetectSleep
            // 
            this.svcDetectSleep.Location = new System.Drawing.Point(95, 128);
            this.svcDetectSleep.Name = "svcDetectSleep";
            this.svcDetectSleep.Size = new System.Drawing.Size(120, 21);
            this.svcDetectSleep.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "检测网络功能：";
            // 
            // svcBindARPEnable
            // 
            this.svcBindARPEnable.AutoSize = true;
            this.svcBindARPEnable.Location = new System.Drawing.Point(95, 103);
            this.svcBindARPEnable.Name = "svcBindARPEnable";
            this.svcBindARPEnable.Size = new System.Drawing.Size(60, 16);
            this.svcBindARPEnable.TabIndex = 6;
            this.svcBindARPEnable.Text = "启用？";
            this.svcBindARPEnable.UseVisualStyleBackColor = true;
            this.svcBindARPEnable.CheckedChanged += new System.EventHandler(this.svcBindARPEnable_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "检测间隔时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "启用ARP 绑定：";
            // 
            // svcGatewayMAC
            // 
            this.svcGatewayMAC.Location = new System.Drawing.Point(95, 74);
            this.svcGatewayMAC.Name = "svcGatewayMAC";
            this.svcGatewayMAC.Size = new System.Drawing.Size(126, 21);
            this.svcGatewayMAC.TabIndex = 5;
            // 
            // svcGatewayIP
            // 
            this.svcGatewayIP.Location = new System.Drawing.Point(95, 47);
            this.svcGatewayIP.Name = "svcGatewayIP";
            this.svcGatewayIP.Size = new System.Drawing.Size(126, 21);
            this.svcGatewayIP.TabIndex = 4;
            // 
            // svcLocalIP
            // 
            this.svcLocalIP.Location = new System.Drawing.Point(95, 20);
            this.svcLocalIP.Name = "svcLocalIP";
            this.svcLocalIP.Size = new System.Drawing.Size(126, 21);
            this.svcLocalIP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "网关MAC 地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "网关 IP 地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本地 IP 地址：";
            // 
            // AutoWrite
            // 
            this.AutoWrite.Location = new System.Drawing.Point(8, 97);
            this.AutoWrite.Name = "AutoWrite";
            this.AutoWrite.Size = new System.Drawing.Size(136, 23);
            this.AutoWrite.TabIndex = 8;
            this.AutoWrite.Text = "网络信息自动填写(&T)";
            this.AutoWrite.UseVisualStyleBackColor = true;
            this.AutoWrite.Click += new System.EventHandler(this.AutoWrite_Click);
            // 
            // UninstallButton
            // 
            this.UninstallButton.Location = new System.Drawing.Point(208, 340);
            this.UninstallButton.Name = "UninstallButton";
            this.UninstallButton.Size = new System.Drawing.Size(93, 23);
            this.UninstallButton.TabIndex = 2;
            this.UninstallButton.Text = "卸载服务(&U)";
            this.UninstallButton.UseVisualStyleBackColor = true;
            this.UninstallButton.Click += new System.EventHandler(this.UninstallButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.AutoWrite);
            this.groupBox2.Location = new System.Drawing.Point(250, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 322);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "说明";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(66, 307);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(77, 12);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "配置详细说明";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 36);
            this.label15.TabIndex = 12;
            this.label15.Text = "开启之后每次服务启动都\r\n会检查远程桌面端口，并\r\n且保证打开。";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 72);
            this.label12.TabIndex = 11;
            this.label12.Text = "远程管理是一套可以不用\r\n登陆服务器就可对服务器\r\n进行一些操作的功能\r\n这里设置连接密码和使用\r\n的端口。客户端就用那个\r\n这个端口连接";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "检测时间间隔以毫秒为\r\n单位建议为30000\r\n也就是30秒一次";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 72);
            this.label5.TabIndex = 9;
            this.label5.Text = "这是一个Windows服务\r\n服务名是SmSvrServ，它\r\n在后台运行，执行着监视\r\n系统的运行，并且在网络\r\n不通的时候尝试修复并且\r\n提供arp绑定功能";
            // 
            // SettingService
            // 
            this.SettingService.Location = new System.Drawing.Point(109, 340);
            this.SettingService.Name = "SettingService";
            this.SettingService.Size = new System.Drawing.Size(93, 23);
            this.SettingService.TabIndex = 10;
            this.SettingService.Text = "服务控制(&S)";
            this.SettingService.UseVisualStyleBackColor = true;
            this.SettingService.Click += new System.EventHandler(this.SettingService_Click);
            // 
            // ServiceStatus
            // 
            this.ServiceStatus.AutoSize = true;
            this.ServiceStatus.Location = new System.Drawing.Point(10, 345);
            this.ServiceStatus.Name = "ServiceStatus";
            this.ServiceStatus.Size = new System.Drawing.Size(41, 12);
            this.ServiceStatus.TabIndex = 11;
            this.ServiceStatus.Text = "未安装";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(347, 366);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(53, 12);
            this.linkLabel3.TabIndex = 14;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "旧版服务";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // SmSvrServForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 384);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.ServiceStatus);
            this.Controls.Add(this.SettingService);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.UninstallButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ApplyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SmSvrServForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "银月服务器服务配置";
            this.Load += new System.EventHandler(this.SilmoonServices_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SilmoonServices_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox svcGatewayMAC;
        private System.Windows.Forms.TextBox svcGatewayIP;
        private System.Windows.Forms.TextBox svcLocalIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UninstallButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox svcBindARPEnable;
        private System.Windows.Forms.Button AutoWrite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SettingService;
        private System.Windows.Forms.Label ServiceStatus;
        private System.Windows.Forms.CheckBox svcDetectEnable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox svcDetectSleep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox netCmdEnable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox netCmdPwd;
        private System.Windows.Forms.TextBox netCmdPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox rdpConnectFixEnable;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox rdpPortFixEnable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}