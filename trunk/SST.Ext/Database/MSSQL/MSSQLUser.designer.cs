namespace SST.Ext.Database.MSSQL
{
    partial class MSSQLUser
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
            this.ctlUsernameTextBox = new System.Windows.Forms.TextBox();
            this.ctlPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ctlDatabaseTextBox = new System.Windows.Forms.TextBox();
            this.ctlSubmitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据库:";
            // 
            // ctlUsernameTextBox
            // 
            this.ctlUsernameTextBox.Location = new System.Drawing.Point(109, 23);
            this.ctlUsernameTextBox.Name = "ctlUsernameTextBox";
            this.ctlUsernameTextBox.Size = new System.Drawing.Size(189, 21);
            this.ctlUsernameTextBox.TabIndex = 3;
            // 
            // ctlPasswordTextBox
            // 
            this.ctlPasswordTextBox.Location = new System.Drawing.Point(109, 50);
            this.ctlPasswordTextBox.Name = "ctlPasswordTextBox";
            this.ctlPasswordTextBox.Size = new System.Drawing.Size(189, 21);
            this.ctlPasswordTextBox.TabIndex = 4;
            // 
            // ctlDatabaseTextBox
            // 
            this.ctlDatabaseTextBox.Location = new System.Drawing.Point(109, 77);
            this.ctlDatabaseTextBox.Name = "ctlDatabaseTextBox";
            this.ctlDatabaseTextBox.Size = new System.Drawing.Size(189, 21);
            this.ctlDatabaseTextBox.TabIndex = 5;
            // 
            // ctlSubmitButton
            // 
            this.ctlSubmitButton.Location = new System.Drawing.Point(223, 104);
            this.ctlSubmitButton.Name = "ctlSubmitButton";
            this.ctlSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.ctlSubmitButton.TabIndex = 6;
            this.ctlSubmitButton.Text = "提交(&A)";
            this.ctlSubmitButton.UseVisualStyleBackColor = true;
            this.ctlSubmitButton.Click += new System.EventHandler(this.ctlSubmitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MSSQLUser
            // 
            this.AcceptButton = this.ctlSubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(385, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctlSubmitButton);
            this.Controls.Add(this.ctlDatabaseTextBox);
            this.Controls.Add(this.ctlPasswordTextBox);
            this.Controls.Add(this.ctlUsernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MSSQLUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSSQLUser";
            this.Load += new System.EventHandler(this.MSSQLUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctlUsernameTextBox;
        private System.Windows.Forms.TextBox ctlPasswordTextBox;
        private System.Windows.Forms.TextBox ctlDatabaseTextBox;
        private System.Windows.Forms.Button ctlSubmitButton;
        private System.Windows.Forms.Button button1;
    }
}