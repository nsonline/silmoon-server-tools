namespace SST.Controls.ExtendInfo
{
    partial class ExtendInfoControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ctlIISPerfText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctlStartControlLinkButton = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IIS通讯量:";
            // 
            // ctlIISPerfText
            // 
            this.ctlIISPerfText.AutoSize = true;
            this.ctlIISPerfText.Location = new System.Drawing.Point(60, 0);
            this.ctlIISPerfText.Name = "ctlIISPerfText";
            this.ctlIISPerfText.Size = new System.Drawing.Size(65, 12);
            this.ctlIISPerfText.TabIndex = 1;
            this.ctlIISPerfText.Text = "Loading...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctlIISPerfText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 69);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // ctlStartControlLinkButton
            // 
            this.ctlStartControlLinkButton.AutoSize = true;
            this.ctlStartControlLinkButton.Location = new System.Drawing.Point(298, 57);
            this.ctlStartControlLinkButton.Name = "ctlStartControlLinkButton";
            this.ctlStartControlLinkButton.Size = new System.Drawing.Size(29, 12);
            this.ctlStartControlLinkButton.TabIndex = 4;
            this.ctlStartControlLinkButton.TabStop = true;
            this.ctlStartControlLinkButton.Text = "启动";
            this.ctlStartControlLinkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ctlStartControlLinkButton_LinkClicked);
            // 
            // ExtendInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctlStartControlLinkButton);
            this.Controls.Add(this.panel1);
            this.Name = "ExtendInfoControl";
            this.Size = new System.Drawing.Size(327, 69);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ctlIISPerfText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel ctlStartControlLinkButton;
    }
}
