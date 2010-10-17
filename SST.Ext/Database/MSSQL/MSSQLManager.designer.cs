namespace SST.Ext.Database.MSSQL
{
    partial class MSSQLManager
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
            this.ctlg1ViewDatabaseGrantButton = new System.Windows.Forms.Button();
            this.ctlg1DeleteDatabaseButton = new System.Windows.Forms.Button();
            this.ctlg1CreateDatabaseButton = new System.Windows.Forms.Button();
            this.ctlg1DatabaseListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ctlsStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlg2ChangePasswordButton = new System.Windows.Forms.Button();
            this.ctlg2ViewUserGrantButton = new System.Windows.Forms.Button();
            this.ctlg2GrantUserDatabaseButton = new System.Windows.Forms.Button();
            this.ctlg2DeleteUserButton = new System.Windows.Forms.Button();
            this.ctlg2CreateUserButton = new System.Windows.Forms.Button();
            this.ctlg2UserListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctlg1ViewDatabaseGrantButton);
            this.groupBox1.Controls.Add(this.ctlg1DeleteDatabaseButton);
            this.groupBox1.Controls.Add(this.ctlg1CreateDatabaseButton);
            this.groupBox1.Controls.Add(this.ctlg1DatabaseListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库";
            // 
            // ctlg1ViewDatabaseGrantButton
            // 
            this.ctlg1ViewDatabaseGrantButton.Location = new System.Drawing.Point(202, 110);
            this.ctlg1ViewDatabaseGrantButton.Name = "ctlg1ViewDatabaseGrantButton";
            this.ctlg1ViewDatabaseGrantButton.Size = new System.Drawing.Size(119, 39);
            this.ctlg1ViewDatabaseGrantButton.TabIndex = 3;
            this.ctlg1ViewDatabaseGrantButton.Text = "查看数据库的用户访问权(&V)";
            this.ctlg1ViewDatabaseGrantButton.UseVisualStyleBackColor = true;
            this.ctlg1ViewDatabaseGrantButton.Click += new System.EventHandler(this.ctlg1ViewDatabaseGrantButton_Click);
            // 
            // ctlg1DeleteDatabaseButton
            // 
            this.ctlg1DeleteDatabaseButton.Location = new System.Drawing.Point(202, 65);
            this.ctlg1DeleteDatabaseButton.Name = "ctlg1DeleteDatabaseButton";
            this.ctlg1DeleteDatabaseButton.Size = new System.Drawing.Size(119, 39);
            this.ctlg1DeleteDatabaseButton.TabIndex = 2;
            this.ctlg1DeleteDatabaseButton.Text = "删除数据库(&D)";
            this.ctlg1DeleteDatabaseButton.UseVisualStyleBackColor = true;
            this.ctlg1DeleteDatabaseButton.Click += new System.EventHandler(this.ctlg1DeleteDatabaseButton_Click);
            // 
            // ctlg1CreateDatabaseButton
            // 
            this.ctlg1CreateDatabaseButton.Location = new System.Drawing.Point(202, 20);
            this.ctlg1CreateDatabaseButton.Name = "ctlg1CreateDatabaseButton";
            this.ctlg1CreateDatabaseButton.Size = new System.Drawing.Size(119, 39);
            this.ctlg1CreateDatabaseButton.TabIndex = 1;
            this.ctlg1CreateDatabaseButton.Text = "添加数据库(&A)";
            this.ctlg1CreateDatabaseButton.UseVisualStyleBackColor = true;
            this.ctlg1CreateDatabaseButton.Click += new System.EventHandler(this.ctlg1CreateDatabaseButton_Click);
            // 
            // ctlg1DatabaseListBox
            // 
            this.ctlg1DatabaseListBox.FormattingEnabled = true;
            this.ctlg1DatabaseListBox.ItemHeight = 12;
            this.ctlg1DatabaseListBox.Location = new System.Drawing.Point(20, 20);
            this.ctlg1DatabaseListBox.Name = "ctlg1DatabaseListBox";
            this.ctlg1DatabaseListBox.Size = new System.Drawing.Size(176, 256);
            this.ctlg1DatabaseListBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlsStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(718, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ctlsStatusText
            // 
            this.ctlsStatusText.Name = "ctlsStatusText";
            this.ctlsStatusText.Size = new System.Drawing.Size(71, 17);
            this.ctlsStatusText.Text = "请求登陆...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctlg2ChangePasswordButton);
            this.groupBox2.Controls.Add(this.ctlg2ViewUserGrantButton);
            this.groupBox2.Controls.Add(this.ctlg2GrantUserDatabaseButton);
            this.groupBox2.Controls.Add(this.ctlg2DeleteUserButton);
            this.groupBox2.Controls.Add(this.ctlg2CreateUserButton);
            this.groupBox2.Controls.Add(this.ctlg2UserListBox);
            this.groupBox2.Location = new System.Drawing.Point(366, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 293);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户  ##开头的是系统用户";
            // 
            // ctlg2ChangePasswordButton
            // 
            this.ctlg2ChangePasswordButton.Location = new System.Drawing.Point(202, 155);
            this.ctlg2ChangePasswordButton.Name = "ctlg2ChangePasswordButton";
            this.ctlg2ChangePasswordButton.Size = new System.Drawing.Size(119, 39);
            this.ctlg2ChangePasswordButton.TabIndex = 5;
            this.ctlg2ChangePasswordButton.Text = "修改密码(&P)";
            this.ctlg2ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ctlg2ChangePasswordButton.Click += new System.EventHandler(this.ctlg2ChangePasswordButton_Click);
            // 
            // ctlg2ViewUserGrantButton
            // 
            this.ctlg2ViewUserGrantButton.Location = new System.Drawing.Point(202, 110);
            this.ctlg2ViewUserGrantButton.Name = "ctlg2ViewUserGrantButton";
            this.ctlg2ViewUserGrantButton.Size = new System.Drawing.Size(119, 39);
            this.ctlg2ViewUserGrantButton.TabIndex = 4;
            this.ctlg2ViewUserGrantButton.Text = "查看用户权限(&G)";
            this.ctlg2ViewUserGrantButton.UseVisualStyleBackColor = true;
            this.ctlg2ViewUserGrantButton.Click += new System.EventHandler(this.ctlg2ViewUserGrantButton_Click);
            // 
            // ctlg2GrantUserDatabaseButton
            // 
            this.ctlg2GrantUserDatabaseButton.Location = new System.Drawing.Point(202, 200);
            this.ctlg2GrantUserDatabaseButton.Name = "ctlg2GrantUserDatabaseButton";
            this.ctlg2GrantUserDatabaseButton.Size = new System.Drawing.Size(119, 39);
            this.ctlg2GrantUserDatabaseButton.TabIndex = 3;
            this.ctlg2GrantUserDatabaseButton.Text = "设置允许访问数据库(&S)";
            this.ctlg2GrantUserDatabaseButton.UseVisualStyleBackColor = true;
            this.ctlg2GrantUserDatabaseButton.Click += new System.EventHandler(this.ctlg2GrantUserDatabaseButton_Click);
            // 
            // ctlg2DeleteUserButton
            // 
            this.ctlg2DeleteUserButton.Location = new System.Drawing.Point(202, 65);
            this.ctlg2DeleteUserButton.Name = "ctlg2DeleteUserButton";
            this.ctlg2DeleteUserButton.Size = new System.Drawing.Size(119, 39);
            this.ctlg2DeleteUserButton.TabIndex = 2;
            this.ctlg2DeleteUserButton.Text = "删除用户(&R)";
            this.ctlg2DeleteUserButton.UseVisualStyleBackColor = true;
            this.ctlg2DeleteUserButton.Click += new System.EventHandler(this.ctlg2DeleteUserButton_Click);
            // 
            // ctlg2CreateUserButton
            // 
            this.ctlg2CreateUserButton.Location = new System.Drawing.Point(202, 20);
            this.ctlg2CreateUserButton.Name = "ctlg2CreateUserButton";
            this.ctlg2CreateUserButton.Size = new System.Drawing.Size(119, 39);
            this.ctlg2CreateUserButton.TabIndex = 1;
            this.ctlg2CreateUserButton.Text = "添加用户(&U)";
            this.ctlg2CreateUserButton.UseVisualStyleBackColor = true;
            this.ctlg2CreateUserButton.Click += new System.EventHandler(this.ctlg2CreateUserButton_Click);
            // 
            // ctlg2UserListBox
            // 
            this.ctlg2UserListBox.FormattingEnabled = true;
            this.ctlg2UserListBox.ItemHeight = 12;
            this.ctlg2UserListBox.Location = new System.Drawing.Point(20, 20);
            this.ctlg2UserListBox.Name = "ctlg2UserListBox";
            this.ctlg2UserListBox.Size = new System.Drawing.Size(176, 256);
            this.ctlg2UserListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "提示:在创建用户、数据库的时候只能使用小写的英文字母，使用中文会出错，大写字母可能会出错。";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "MSSQL 配置\r\n(MSSQL 2005兼容)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "如果用户已经设置到数据库，应该拥有访问权限，但是没有，那么请尝试重新设置一遍！";
            // 
            // MSSQLManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MSSQLManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSSQL 管理";
            this.Shown += new System.EventHandler(this.MSSQLManager_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MSSQLManager_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ctlg1CreateDatabaseButton;
        private System.Windows.Forms.ListBox ctlg1DatabaseListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ctlsStatusText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ctlg2CreateUserButton;
        private System.Windows.Forms.ListBox ctlg2UserListBox;
        private System.Windows.Forms.Button ctlg2DeleteUserButton;
        private System.Windows.Forms.Button ctlg2GrantUserDatabaseButton;
        private System.Windows.Forms.Button ctlg1DeleteDatabaseButton;
        private System.Windows.Forms.Button ctlg1ViewDatabaseGrantButton;
        private System.Windows.Forms.Button ctlg2ViewUserGrantButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ctlg2ChangePasswordButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}