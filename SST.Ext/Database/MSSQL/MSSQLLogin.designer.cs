namespace SST.Ext.Database.MSSQL
{
    partial class MSSQLLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlServerTextBox = new System.Windows.Forms.TextBox();
            this.ctlUsernameTextBox = new System.Windows.Forms.TextBox();
            this.ctlPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ctlDatabaseTextBox = new System.Windows.Forms.TextBox();
            this.ctlLoginButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctlUseWindowsAuth = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "登陆密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "默认数据库:";
            // 
            // ctlServerTextBox
            // 
            this.ctlServerTextBox.Location = new System.Drawing.Point(113, 12);
            this.ctlServerTextBox.Name = "ctlServerTextBox";
            this.ctlServerTextBox.Size = new System.Drawing.Size(166, 21);
            this.ctlServerTextBox.TabIndex = 4;
            this.ctlServerTextBox.Text = "localhost";
            // 
            // ctlUsernameTextBox
            // 
            this.ctlUsernameTextBox.Enabled = false;
            this.ctlUsernameTextBox.Location = new System.Drawing.Point(113, 61);
            this.ctlUsernameTextBox.Name = "ctlUsernameTextBox";
            this.ctlUsernameTextBox.Size = new System.Drawing.Size(166, 21);
            this.ctlUsernameTextBox.TabIndex = 5;
            this.ctlUsernameTextBox.Text = "sa";
            // 
            // ctlPasswordTextBox
            // 
            this.ctlPasswordTextBox.Enabled = false;
            this.ctlPasswordTextBox.Location = new System.Drawing.Point(113, 88);
            this.ctlPasswordTextBox.Name = "ctlPasswordTextBox";
            this.ctlPasswordTextBox.Size = new System.Drawing.Size(166, 21);
            this.ctlPasswordTextBox.TabIndex = 6;
            this.ctlPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ctlDatabaseTextBox
            // 
            this.ctlDatabaseTextBox.Enabled = false;
            this.ctlDatabaseTextBox.Location = new System.Drawing.Point(113, 115);
            this.ctlDatabaseTextBox.Name = "ctlDatabaseTextBox";
            this.ctlDatabaseTextBox.Size = new System.Drawing.Size(166, 21);
            this.ctlDatabaseTextBox.TabIndex = 7;
            this.ctlDatabaseTextBox.Text = "Master";
            // 
            // ctlLoginButton
            // 
            this.ctlLoginButton.Location = new System.Drawing.Point(204, 142);
            this.ctlLoginButton.Name = "ctlLoginButton";
            this.ctlLoginButton.Size = new System.Drawing.Size(75, 23);
            this.ctlLoginButton.TabIndex = 8;
            this.ctlLoginButton.Text = "登陆(&L)";
            this.ctlLoginButton.UseVisualStyleBackColor = true;
            this.ctlLoginButton.Click += new System.EventHandler(this.ctlLoginButton_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(258, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlUseWindowsAuth
            // 
            this.ctlUseWindowsAuth.AutoSize = true;
            this.ctlUseWindowsAuth.Checked = true;
            this.ctlUseWindowsAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctlUseWindowsAuth.Location = new System.Drawing.Point(113, 39);
            this.ctlUseWindowsAuth.Name = "ctlUseWindowsAuth";
            this.ctlUseWindowsAuth.Size = new System.Drawing.Size(114, 16);
            this.ctlUseWindowsAuth.TabIndex = 11;
            this.ctlUseWindowsAuth.Text = "使用Windows认证";
            this.ctlUseWindowsAuth.UseVisualStyleBackColor = true;
            this.ctlUseWindowsAuth.CheckedChanged += new System.EventHandler(this.ctlUseWindowsAuth_CheckedChanged);
            // 
            // MSSQLLogin
            // 
            this.AcceptButton = this.ctlLoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(357, 179);
            this.Controls.Add(this.ctlUseWindowsAuth);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctlLoginButton);
            this.Controls.Add(this.ctlDatabaseTextBox);
            this.Controls.Add(this.ctlPasswordTextBox);
            this.Controls.Add(this.ctlUsernameTextBox);
            this.Controls.Add(this.ctlServerTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MSSQLLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆到MSSQL";
            this.Shown += new System.EventHandler(this.MSSQLLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctlServerTextBox;
        private System.Windows.Forms.TextBox ctlUsernameTextBox;
        private System.Windows.Forms.TextBox ctlPasswordTextBox;
        private System.Windows.Forms.TextBox ctlDatabaseTextBox;
        private System.Windows.Forms.Button ctlLoginButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ctlUseWindowsAuth;
    }
}