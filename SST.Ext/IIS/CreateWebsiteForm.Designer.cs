namespace SST.Ext.IIS
{
    partial class CreateWebsiteForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlSelectDirectory = new System.Windows.Forms.Button();
            this.ctlDirectory = new System.Windows.Forms.TextBox();
            this.ctlSiteName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlBindingsList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelIPTip = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lablePortTip = new System.Windows.Forms.Label();
            this.ctlAddBindings = new System.Windows.Forms.Button();
            this.ctlIPList = new System.Windows.Forms.ComboBox();
            this.ctlPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctlDomain = new System.Windows.Forms.TextBox();
            this.ctlRemoveBindings = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ctlSetDirectorySec = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctlSetUserSec = new System.Windows.Forms.RadioButton();
            this.ctlManualUserSec = new System.Windows.Forms.RadioButton();
            this.ctlAutoUserSec = new System.Windows.Forms.RadioButton();
            this.ctlUserPanel = new System.Windows.Forms.Panel();
            this.ctlSecUserSetToDirectory = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctlUserTip = new System.Windows.Forms.Label();
            this.ctlSecPassword = new System.Windows.Forms.TextBox();
            this.ctlSecUser = new System.Windows.Forms.TextBox();
            this.ctlUserSec = new System.Windows.Forms.CheckBox();
            this.ctlConfirm = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctlRb5 = new System.Windows.Forms.RadioButton();
            this.ctlRb4 = new System.Windows.Forms.RadioButton();
            this.ctlRb3 = new System.Windows.Forms.RadioButton();
            this.ctlRb2 = new System.Windows.Forms.RadioButton();
            this.ctlRb1 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ctlAppList = new System.Windows.Forms.ComboBox();
            this.ctlStatus = new System.Windows.Forms.Label();
            this.ctlMoreOptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ctlLogUseLocalTime = new System.Windows.Forms.CheckBox();
            this.ctlLogSetToD = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ctlUserPanel.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctlSelectDirectory);
            this.groupBox1.Controls.Add(this.ctlDirectory);
            this.groupBox1.Controls.Add(this.ctlSiteName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础信息";
            // 
            // ctlSelectDirectory
            // 
            this.ctlSelectDirectory.Location = new System.Drawing.Point(315, 51);
            this.ctlSelectDirectory.Name = "ctlSelectDirectory";
            this.ctlSelectDirectory.Size = new System.Drawing.Size(31, 23);
            this.ctlSelectDirectory.TabIndex = 3;
            this.ctlSelectDirectory.Text = "...";
            this.ctlSelectDirectory.UseVisualStyleBackColor = true;
            this.ctlSelectDirectory.Click += new System.EventHandler(this.ctlSelectDirectory_Click);
            // 
            // ctlDirectory
            // 
            this.ctlDirectory.Location = new System.Drawing.Point(97, 51);
            this.ctlDirectory.Name = "ctlDirectory";
            this.ctlDirectory.Size = new System.Drawing.Size(212, 21);
            this.ctlDirectory.TabIndex = 2;
            // 
            // ctlSiteName
            // 
            this.ctlSiteName.Location = new System.Drawing.Point(97, 21);
            this.ctlSiteName.Name = "ctlSiteName";
            this.ctlSiteName.Size = new System.Drawing.Size(249, 21);
            this.ctlSiteName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "网站主目录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "网站名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "当前绑定";
            // 
            // ctlBindingsList
            // 
            this.ctlBindingsList.FormattingEnabled = true;
            this.ctlBindingsList.ItemHeight = 12;
            this.ctlBindingsList.Location = new System.Drawing.Point(97, 22);
            this.ctlBindingsList.Name = "ctlBindingsList";
            this.ctlBindingsList.Size = new System.Drawing.Size(249, 64);
            this.ctlBindingsList.TabIndex = 4;
            this.ctlBindingsList.SelectedIndexChanged += new System.EventHandler(this.ctlBindingsList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.ctlRemoveBindings);
            this.groupBox2.Controls.Add(this.ctlBindingsList);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 201);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "域名.IP.端口绑定";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelIPTip);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lablePortTip);
            this.groupBox3.Controls.Add(this.ctlAddBindings);
            this.groupBox3.Controls.Add(this.ctlIPList);
            this.groupBox3.Controls.Add(this.ctlPort);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ctlDomain);
            this.groupBox3.Location = new System.Drawing.Point(6, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 97);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加绑定";
            // 
            // labelIPTip
            // 
            this.labelIPTip.AutoSize = true;
            this.labelIPTip.Location = new System.Drawing.Point(95, 38);
            this.labelIPTip.Name = "labelIPTip";
            this.labelIPTip.Size = new System.Drawing.Size(119, 12);
            this.labelIPTip.TabIndex = 13;
            this.labelIPTip.Text = "*号为任意IP 推荐*号";
            this.labelIPTip.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "IP和端口";
            // 
            // lablePortTip
            // 
            this.lablePortTip.AutoSize = true;
            this.lablePortTip.Location = new System.Drawing.Point(277, 38);
            this.lablePortTip.Name = "lablePortTip";
            this.lablePortTip.Size = new System.Drawing.Size(65, 12);
            this.lablePortTip.TabIndex = 9;
            this.lablePortTip.Text = "绑定端口号";
            this.lablePortTip.Visible = false;
            // 
            // ctlAddBindings
            // 
            this.ctlAddBindings.Location = new System.Drawing.Point(265, 52);
            this.ctlAddBindings.Name = "ctlAddBindings";
            this.ctlAddBindings.Size = new System.Drawing.Size(75, 22);
            this.ctlAddBindings.TabIndex = 12;
            this.ctlAddBindings.Text = "添加(&A)";
            this.ctlAddBindings.UseVisualStyleBackColor = true;
            this.ctlAddBindings.Click += new System.EventHandler(this.ctlAddBindings_Click);
            // 
            // ctlIPList
            // 
            this.ctlIPList.FormattingEnabled = true;
            this.ctlIPList.Location = new System.Drawing.Point(91, 15);
            this.ctlIPList.Name = "ctlIPList";
            this.ctlIPList.Size = new System.Drawing.Size(186, 20);
            this.ctlIPList.TabIndex = 6;
            this.ctlIPList.Leave += new System.EventHandler(this.ctlIPList_Leave);
            this.ctlIPList.Enter += new System.EventHandler(this.ctlIPList_Enter);
            // 
            // ctlPort
            // 
            this.ctlPort.Location = new System.Drawing.Point(283, 14);
            this.ctlPort.Name = "ctlPort";
            this.ctlPort.Size = new System.Drawing.Size(57, 21);
            this.ctlPort.TabIndex = 8;
            this.ctlPort.Text = "80";
            this.ctlPort.Leave += new System.EventHandler(this.ctlPort_Leave);
            this.ctlPort.Enter += new System.EventHandler(this.ctlPort_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "域名";
            // 
            // ctlDomain
            // 
            this.ctlDomain.Location = new System.Drawing.Point(91, 53);
            this.ctlDomain.Name = "ctlDomain";
            this.ctlDomain.Size = new System.Drawing.Size(163, 21);
            this.ctlDomain.TabIndex = 10;
            // 
            // ctlRemoveBindings
            // 
            this.ctlRemoveBindings.Location = new System.Drawing.Point(16, 54);
            this.ctlRemoveBindings.Name = "ctlRemoveBindings";
            this.ctlRemoveBindings.Size = new System.Drawing.Size(75, 30);
            this.ctlRemoveBindings.TabIndex = 3;
            this.ctlRemoveBindings.Text = "移除(&R)";
            this.ctlRemoveBindings.UseVisualStyleBackColor = true;
            this.ctlRemoveBindings.Visible = false;
            this.ctlRemoveBindings.Click += new System.EventHandler(this.ctlRemoveBindings_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ctlSetDirectorySec);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.ctlUserPanel);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(384, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 182);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "安全";
            // 
            // ctlSetDirectorySec
            // 
            this.ctlSetDirectorySec.AutoSize = true;
            this.ctlSetDirectorySec.Enabled = false;
            this.ctlSetDirectorySec.Location = new System.Drawing.Point(15, 157);
            this.ctlSetDirectorySec.Name = "ctlSetDirectorySec";
            this.ctlSetDirectorySec.Size = new System.Drawing.Size(216, 16);
            this.ctlSetDirectorySec.TabIndex = 7;
            this.ctlSetDirectorySec.Text = "独立处理目录安全(做过安全的不选)";
            this.ctlSetDirectorySec.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctlSetUserSec);
            this.panel1.Controls.Add(this.ctlManualUserSec);
            this.panel1.Controls.Add(this.ctlAutoUserSec);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 61);
            this.panel1.TabIndex = 6;
            // 
            // ctlSetUserSec
            // 
            this.ctlSetUserSec.AutoSize = true;
            this.ctlSetUserSec.Location = new System.Drawing.Point(3, 37);
            this.ctlSetUserSec.Name = "ctlSetUserSec";
            this.ctlSetUserSec.Size = new System.Drawing.Size(131, 16);
            this.ctlSetUserSec.TabIndex = 2;
            this.ctlSetUserSec.Text = "指定一个存在的用户";
            this.ctlSetUserSec.UseVisualStyleBackColor = true;
            this.ctlSetUserSec.CheckedChanged += new System.EventHandler(this.ctlSetUserSec_CheckedChanged);
            // 
            // ctlManualUserSec
            // 
            this.ctlManualUserSec.AutoSize = true;
            this.ctlManualUserSec.Location = new System.Drawing.Point(3, 21);
            this.ctlManualUserSec.Name = "ctlManualUserSec";
            this.ctlManualUserSec.Size = new System.Drawing.Size(203, 16);
            this.ctlManualUserSec.TabIndex = 1;
            this.ctlManualUserSec.Text = "手动创建独立用户（非新手使用）";
            this.ctlManualUserSec.UseVisualStyleBackColor = true;
            this.ctlManualUserSec.CheckedChanged += new System.EventHandler(this.ctlManualUserSec_CheckedChanged);
            // 
            // ctlAutoUserSec
            // 
            this.ctlAutoUserSec.AutoSize = true;
            this.ctlAutoUserSec.Location = new System.Drawing.Point(3, 4);
            this.ctlAutoUserSec.Name = "ctlAutoUserSec";
            this.ctlAutoUserSec.Size = new System.Drawing.Size(167, 16);
            this.ctlAutoUserSec.TabIndex = 0;
            this.ctlAutoUserSec.Text = "自动创建独立用户（推荐）";
            this.ctlAutoUserSec.UseVisualStyleBackColor = true;
            this.ctlAutoUserSec.CheckedChanged += new System.EventHandler(this.ctlAutoUserSec_CheckedChanged);
            // 
            // ctlUserPanel
            // 
            this.ctlUserPanel.Controls.Add(this.ctlSecUserSetToDirectory);
            this.ctlUserPanel.Controls.Add(this.label6);
            this.ctlUserPanel.Controls.Add(this.ctlUserTip);
            this.ctlUserPanel.Controls.Add(this.ctlSecPassword);
            this.ctlUserPanel.Controls.Add(this.ctlSecUser);
            this.ctlUserPanel.Enabled = false;
            this.ctlUserPanel.Location = new System.Drawing.Point(12, 83);
            this.ctlUserPanel.Name = "ctlUserPanel";
            this.ctlUserPanel.Size = new System.Drawing.Size(209, 73);
            this.ctlUserPanel.TabIndex = 5;
            // 
            // ctlSecUserSetToDirectory
            // 
            this.ctlSecUserSetToDirectory.AutoSize = true;
            this.ctlSecUserSetToDirectory.Checked = true;
            this.ctlSecUserSetToDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctlSecUserSetToDirectory.Location = new System.Drawing.Point(3, 56);
            this.ctlSecUserSetToDirectory.Name = "ctlSecUserSetToDirectory";
            this.ctlSecUserSetToDirectory.Size = new System.Drawing.Size(204, 16);
            this.ctlSecUserSetToDirectory.TabIndex = 8;
            this.ctlSecUserSetToDirectory.Text = "将以上安全用户设置到网站主目录";
            this.ctlSecUserSetToDirectory.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "密码";
            // 
            // ctlUserTip
            // 
            this.ctlUserTip.AutoSize = true;
            this.ctlUserTip.Location = new System.Drawing.Point(1, 6);
            this.ctlUserTip.Name = "ctlUserTip";
            this.ctlUserTip.Size = new System.Drawing.Size(41, 12);
            this.ctlUserTip.TabIndex = 1;
            this.ctlUserTip.Text = "新用户";
            // 
            // ctlSecPassword
            // 
            this.ctlSecPassword.Location = new System.Drawing.Point(45, 30);
            this.ctlSecPassword.Name = "ctlSecPassword";
            this.ctlSecPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctlSecPassword.Size = new System.Drawing.Size(152, 21);
            this.ctlSecPassword.TabIndex = 3;
            // 
            // ctlSecUser
            // 
            this.ctlSecUser.Location = new System.Drawing.Point(45, 0);
            this.ctlSecUser.Name = "ctlSecUser";
            this.ctlSecUser.Size = new System.Drawing.Size(152, 21);
            this.ctlSecUser.TabIndex = 2;
            this.ctlSecUser.DoubleClick += new System.EventHandler(this.ctlSecUser_DoubleClick);
            // 
            // ctlUserSec
            // 
            this.ctlUserSec.AutoSize = true;
            this.ctlUserSec.Location = new System.Drawing.Point(435, 11);
            this.ctlUserSec.Name = "ctlUserSec";
            this.ctlUserSec.Size = new System.Drawing.Size(72, 16);
            this.ctlUserSec.TabIndex = 9;
            this.ctlUserSec.Text = "设置安全";
            this.ctlUserSec.UseVisualStyleBackColor = true;
            this.ctlUserSec.CheckedChanged += new System.EventHandler(this.ctlUserSec_CheckedChanged);
            // 
            // ctlConfirm
            // 
            this.ctlConfirm.Location = new System.Drawing.Point(506, 279);
            this.ctlConfirm.Name = "ctlConfirm";
            this.ctlConfirm.Size = new System.Drawing.Size(119, 52);
            this.ctlConfirm.TabIndex = 10;
            this.ctlConfirm.Text = "确认创建(&A)";
            this.ctlConfirm.UseVisualStyleBackColor = true;
            this.ctlConfirm.Click += new System.EventHandler(this.ctlConfirm_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Location = new System.Drawing.Point(384, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(116, 131);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "脚本";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctlRb5);
            this.panel2.Controls.Add(this.ctlRb4);
            this.panel2.Controls.Add(this.ctlRb3);
            this.panel2.Controls.Add(this.ctlRb2);
            this.panel2.Controls.Add(this.ctlRb1);
            this.panel2.Location = new System.Drawing.Point(9, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 109);
            this.panel2.TabIndex = 0;
            // 
            // ctlRb5
            // 
            this.ctlRb5.AutoSize = true;
            this.ctlRb5.Location = new System.Drawing.Point(7, 92);
            this.ctlRb5.Name = "ctlRb5";
            this.ctlRb5.Size = new System.Drawing.Size(95, 16);
            this.ctlRb5.TabIndex = 4;
            this.ctlRb5.Text = "ASP+PHP+.NET";
            this.ctlRb5.UseVisualStyleBackColor = true;
            this.ctlRb5.CheckedChanged += new System.EventHandler(this.ctlRb5_CheckedChanged);
            // 
            // ctlRb4
            // 
            this.ctlRb4.AutoSize = true;
            this.ctlRb4.Location = new System.Drawing.Point(7, 70);
            this.ctlRb4.Name = "ctlRb4";
            this.ctlRb4.Size = new System.Drawing.Size(65, 16);
            this.ctlRb4.TabIndex = 3;
            this.ctlRb4.Text = "ASP+PHP";
            this.ctlRb4.UseVisualStyleBackColor = true;
            this.ctlRb4.CheckedChanged += new System.EventHandler(this.ctlRb4_CheckedChanged);
            // 
            // ctlRb3
            // 
            this.ctlRb3.AutoSize = true;
            this.ctlRb3.Location = new System.Drawing.Point(7, 48);
            this.ctlRb3.Name = "ctlRb3";
            this.ctlRb3.Size = new System.Drawing.Size(53, 16);
            this.ctlRb3.TabIndex = 2;
            this.ctlRb3.Text = "仅PHP";
            this.ctlRb3.UseVisualStyleBackColor = true;
            this.ctlRb3.CheckedChanged += new System.EventHandler(this.ctlRb3_CheckedChanged);
            // 
            // ctlRb2
            // 
            this.ctlRb2.AutoSize = true;
            this.ctlRb2.Location = new System.Drawing.Point(7, 26);
            this.ctlRb2.Name = "ctlRb2";
            this.ctlRb2.Size = new System.Drawing.Size(53, 16);
            this.ctlRb2.TabIndex = 1;
            this.ctlRb2.Text = "仅ASP";
            this.ctlRb2.UseVisualStyleBackColor = true;
            this.ctlRb2.CheckedChanged += new System.EventHandler(this.ctlRb2_CheckedChanged);
            // 
            // ctlRb1
            // 
            this.ctlRb1.AutoSize = true;
            this.ctlRb1.Checked = true;
            this.ctlRb1.Location = new System.Drawing.Point(7, 4);
            this.ctlRb1.Name = "ctlRb1";
            this.ctlRb1.Size = new System.Drawing.Size(71, 16);
            this.ctlRb1.TabIndex = 0;
            this.ctlRb1.TabStop = true;
            this.ctlRb1.Text = "全能脚本";
            this.ctlRb1.UseVisualStyleBackColor = true;
            this.ctlRb1.CheckedChanged += new System.EventHandler(this.ctlRb1_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ctlAppList);
            this.groupBox6.Location = new System.Drawing.Point(506, 201);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(119, 50);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "应用池";
            // 
            // ctlAppList
            // 
            this.ctlAppList.FormattingEnabled = true;
            this.ctlAppList.Location = new System.Drawing.Point(6, 14);
            this.ctlAppList.Name = "ctlAppList";
            this.ctlAppList.Size = new System.Drawing.Size(107, 20);
            this.ctlAppList.TabIndex = 0;
            // 
            // ctlStatus
            // 
            this.ctlStatus.AutoSize = true;
            this.ctlStatus.Location = new System.Drawing.Point(16, 319);
            this.ctlStatus.Name = "ctlStatus";
            this.ctlStatus.Size = new System.Drawing.Size(47, 12);
            this.ctlStatus.TabIndex = 14;
            this.ctlStatus.Text = "就绪...";
            // 
            // ctlMoreOptionsCheckBox
            // 
            this.ctlMoreOptionsCheckBox.AutoSize = true;
            this.ctlMoreOptionsCheckBox.Location = new System.Drawing.Point(506, 257);
            this.ctlMoreOptionsCheckBox.Name = "ctlMoreOptionsCheckBox";
            this.ctlMoreOptionsCheckBox.Size = new System.Drawing.Size(90, 16);
            this.ctlMoreOptionsCheckBox.TabIndex = 15;
            this.ctlMoreOptionsCheckBox.Text = "更多选项(&M)";
            this.ctlMoreOptionsCheckBox.UseVisualStyleBackColor = true;
            this.ctlMoreOptionsCheckBox.CheckedChanged += new System.EventHandler(this.ctlMoreOptionsCheckBox_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ctlLogSetToD);
            this.groupBox7.Controls.Add(this.ctlLogUseLocalTime);
            this.groupBox7.Location = new System.Drawing.Point(12, 343);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(613, 100);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "__选项___";
            // 
            // ctlLogUseLocalTime
            // 
            this.ctlLogUseLocalTime.AutoSize = true;
            this.ctlLogUseLocalTime.Location = new System.Drawing.Point(6, 20);
            this.ctlLogUseLocalTime.Name = "ctlLogUseLocalTime";
            this.ctlLogUseLocalTime.Size = new System.Drawing.Size(120, 16);
            this.ctlLogUseLocalTime.TabIndex = 0;
            this.ctlLogUseLocalTime.Text = "日志使用本地时间";
            this.ctlLogUseLocalTime.UseVisualStyleBackColor = true;
            // 
            // ctlLogSetToD
            // 
            this.ctlLogSetToD.AutoSize = true;
            this.ctlLogSetToD.Location = new System.Drawing.Point(6, 42);
            this.ctlLogSetToD.Name = "ctlLogSetToD";
            this.ctlLogSetToD.Size = new System.Drawing.Size(156, 16);
            this.ctlLogSetToD.TabIndex = 1;
            this.ctlLogSetToD.Text = "日志设置到D:\\LogFiles\\";
            this.ctlLogSetToD.UseVisualStyleBackColor = true;
            // 
            // CreateWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 455);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.ctlMoreOptionsCheckBox);
            this.Controls.Add(this.ctlStatus);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.ctlConfirm);
            this.Controls.Add(this.ctlUserSec);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateWebsite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新站点";
            this.Load += new System.EventHandler(this.CreateWebsite_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateWebsite_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ctlUserPanel.ResumeLayout(false);
            this.ctlUserPanel.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctlDirectory;
        private System.Windows.Forms.TextBox ctlSiteName;
        private System.Windows.Forms.ListBox ctlBindingsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ctlIPList;
        private System.Windows.Forms.Label lablePortTip;
        private System.Windows.Forms.TextBox ctlPort;
        private System.Windows.Forms.TextBox ctlDomain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ctlRemoveBindings;
        private System.Windows.Forms.Button ctlAddBindings;
        private System.Windows.Forms.Label labelIPTip;
        private System.Windows.Forms.Button ctlSelectDirectory;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ctlSecPassword;
        private System.Windows.Forms.TextBox ctlSecUser;
        private System.Windows.Forms.Label ctlUserTip;
        private System.Windows.Forms.CheckBox ctlUserSec;
        private System.Windows.Forms.Panel ctlUserPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ctlSetUserSec;
        private System.Windows.Forms.RadioButton ctlManualUserSec;
        private System.Windows.Forms.RadioButton ctlAutoUserSec;
        private System.Windows.Forms.CheckBox ctlSetDirectorySec;
        private System.Windows.Forms.CheckBox ctlSecUserSetToDirectory;
        private System.Windows.Forms.Button ctlConfirm;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton ctlRb2;
        private System.Windows.Forms.RadioButton ctlRb1;
        private System.Windows.Forms.RadioButton ctlRb5;
        private System.Windows.Forms.RadioButton ctlRb4;
        private System.Windows.Forms.RadioButton ctlRb3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox ctlAppList;
        private System.Windows.Forms.Label ctlStatus;
        private System.Windows.Forms.CheckBox ctlMoreOptionsCheckBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox ctlLogSetToD;
        private System.Windows.Forms.CheckBox ctlLogUseLocalTime;
    }
}