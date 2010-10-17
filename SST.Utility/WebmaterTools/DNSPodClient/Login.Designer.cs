namespace DNSPodClient
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ctlUsernameTextBox = new System.Windows.Forms.TextBox();
            this.ctlPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ctlLoginButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.ctlSaveLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ctlUsernameTextBox
            // 
            this.ctlUsernameTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.ctlUsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(130)))), ((int)(((byte)(237)))));
            this.ctlUsernameTextBox.Location = new System.Drawing.Point(61, 26);
            this.ctlUsernameTextBox.Name = "ctlUsernameTextBox";
            this.ctlUsernameTextBox.Size = new System.Drawing.Size(243, 30);
            this.ctlUsernameTextBox.TabIndex = 1;
            // 
            // ctlPasswordTextBox
            // 
            this.ctlPasswordTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.ctlPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(130)))), ((int)(((byte)(237)))));
            this.ctlPasswordTextBox.Location = new System.Drawing.Point(61, 62);
            this.ctlPasswordTextBox.Name = "ctlPasswordTextBox";
            this.ctlPasswordTextBox.Size = new System.Drawing.Size(243, 30);
            this.ctlPasswordTextBox.TabIndex = 2;
            this.ctlPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ctlLoginButton
            // 
            this.ctlLoginButton.Location = new System.Drawing.Point(202, 98);
            this.ctlLoginButton.Name = "ctlLoginButton";
            this.ctlLoginButton.Size = new System.Drawing.Size(102, 29);
            this.ctlLoginButton.TabIndex = 0;
            this.ctlLoginButton.Text = "登陆";
            this.ctlLoginButton.UseVisualStyleBackColor = true;
            this.ctlLoginButton.Click += new System.EventHandler(this.ctlLoginButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(207, 134);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 12);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DNSPod.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(278, 134);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(71, 12);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Silmoon.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ctlSaveLoginCheckBox
            // 
            this.ctlSaveLoginCheckBox.AutoSize = true;
            this.ctlSaveLoginCheckBox.Checked = true;
            this.ctlSaveLoginCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctlSaveLoginCheckBox.Location = new System.Drawing.Point(124, 105);
            this.ctlSaveLoginCheckBox.Name = "ctlSaveLoginCheckBox";
            this.ctlSaveLoginCheckBox.Size = new System.Drawing.Size(72, 16);
            this.ctlSaveLoginCheckBox.TabIndex = 5;
            this.ctlSaveLoginCheckBox.Text = "记忆帐户";
            this.ctlSaveLoginCheckBox.UseVisualStyleBackColor = true;
            this.ctlSaveLoginCheckBox.CheckedChanged += new System.EventHandler(this.ctlSaveLoginCheckBox_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.ctlLoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 150);
            this.Controls.Add(this.ctlSaveLoginCheckBox);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ctlLoginButton);
            this.Controls.Add(this.ctlPasswordTextBox);
            this.Controls.Add(this.ctlUsernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录到DNSPod";
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctlUsernameTextBox;
        private System.Windows.Forms.TextBox ctlPasswordTextBox;
        private System.Windows.Forms.Button ctlLoginButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox ctlSaveLoginCheckBox;
    }
}

