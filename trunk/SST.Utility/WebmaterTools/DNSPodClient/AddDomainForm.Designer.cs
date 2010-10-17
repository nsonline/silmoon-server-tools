namespace DNSPodClient
{
    partial class AddDomainForm
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
            this.ctlDomainTextBox = new System.Windows.Forms.TextBox();
            this.ctlAddButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "域名：";
            // 
            // ctlDomainTextBox
            // 
            this.ctlDomainTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlDomainTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(130)))), ((int)(((byte)(237)))));
            this.ctlDomainTextBox.Location = new System.Drawing.Point(60, 12);
            this.ctlDomainTextBox.Name = "ctlDomainTextBox";
            this.ctlDomainTextBox.Size = new System.Drawing.Size(250, 30);
            this.ctlDomainTextBox.TabIndex = 1;
            // 
            // ctlAddButton
            // 
            this.ctlAddButton.Location = new System.Drawing.Point(210, 55);
            this.ctlAddButton.Name = "ctlAddButton";
            this.ctlAddButton.Size = new System.Drawing.Size(100, 29);
            this.ctlAddButton.TabIndex = 2;
            this.ctlAddButton.Text = "确定";
            this.ctlAddButton.UseVisualStyleBackColor = true;
            this.ctlAddButton.Click += new System.EventHandler(this.ctlAddButton_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(81, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddDomainForm
            // 
            this.AcceptButton = this.ctlAddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(348, 105);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ctlAddButton);
            this.Controls.Add(this.ctlDomainTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDomainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新域名";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctlDomainTextBox;
        private System.Windows.Forms.Button ctlAddButton;
        private System.Windows.Forms.Button button2;
    }
}