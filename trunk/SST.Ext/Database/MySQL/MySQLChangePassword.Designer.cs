namespace SST.Ext.Database.MySQL
{
    partial class MySQLChangePassword
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
            this.ctlPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ctlRepasswordTextBox = new System.Windows.Forms.TextBox();
            this.ctlSubmitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "新密码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "确认一次:";
            // 
            // ctlPasswordTextBox
            // 
            this.ctlPasswordTextBox.Location = new System.Drawing.Point(95, 18);
            this.ctlPasswordTextBox.Name = "ctlPasswordTextBox";
            this.ctlPasswordTextBox.Size = new System.Drawing.Size(186, 21);
            this.ctlPasswordTextBox.TabIndex = 2;
            // 
            // ctlRepasswordTextBox
            // 
            this.ctlRepasswordTextBox.Location = new System.Drawing.Point(95, 44);
            this.ctlRepasswordTextBox.Name = "ctlRepasswordTextBox";
            this.ctlRepasswordTextBox.Size = new System.Drawing.Size(186, 21);
            this.ctlRepasswordTextBox.TabIndex = 3;
            // 
            // ctlSubmitButton
            // 
            this.ctlSubmitButton.Location = new System.Drawing.Point(206, 71);
            this.ctlSubmitButton.Name = "ctlSubmitButton";
            this.ctlSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.ctlSubmitButton.TabIndex = 4;
            this.ctlSubmitButton.Text = "提交(&A)";
            this.ctlSubmitButton.UseVisualStyleBackColor = true;
            this.ctlSubmitButton.Click += new System.EventHandler(this.ctlSubmitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MySQLChangePassword
            // 
            this.AcceptButton = this.ctlSubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(340, 109);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctlSubmitButton);
            this.Controls.Add(this.ctlRepasswordTextBox);
            this.Controls.Add(this.ctlPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MySQLChangePassword";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctlPasswordTextBox;
        private System.Windows.Forms.TextBox ctlRepasswordTextBox;
        private System.Windows.Forms.Button ctlSubmitButton;
        private System.Windows.Forms.Button button1;
    }
}