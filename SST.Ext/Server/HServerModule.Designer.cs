namespace SST.Ext.Server
{
    partial class HServerModule
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
            this.UnRegAllButton = new System.Windows.Forms.Button();
            this.RegAllButton = new System.Windows.Forms.Button();
            this.DangerModuleGroupBox = new System.Windows.Forms.GroupBox();
            this.DangerModuleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnRegAllButton
            // 
            this.UnRegAllButton.Location = new System.Drawing.Point(17, 20);
            this.UnRegAllButton.Name = "UnRegAllButton";
            this.UnRegAllButton.Size = new System.Drawing.Size(79, 23);
            this.UnRegAllButton.TabIndex = 0;
            this.UnRegAllButton.Text = "卸载全部(&U)";
            this.UnRegAllButton.UseVisualStyleBackColor = true;
            this.UnRegAllButton.Click += new System.EventHandler(this.UnRegAll_Click);
            // 
            // RegAllButton
            // 
            this.RegAllButton.Location = new System.Drawing.Point(102, 20);
            this.RegAllButton.Name = "RegAllButton";
            this.RegAllButton.Size = new System.Drawing.Size(79, 23);
            this.RegAllButton.TabIndex = 1;
            this.RegAllButton.Text = "恢复全部(&R)";
            this.RegAllButton.UseVisualStyleBackColor = true;
            this.RegAllButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // DangerModuleGroupBox
            // 
            this.DangerModuleGroupBox.Controls.Add(this.UnRegAllButton);
            this.DangerModuleGroupBox.Controls.Add(this.RegAllButton);
            this.DangerModuleGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DangerModuleGroupBox.Name = "DangerModuleGroupBox";
            this.DangerModuleGroupBox.Size = new System.Drawing.Size(204, 68);
            this.DangerModuleGroupBox.TabIndex = 2;
            this.DangerModuleGroupBox.TabStop = false;
            this.DangerModuleGroupBox.Text = "高危组件";
            // 
            // HServerModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 92);
            this.Controls.Add(this.DangerModuleGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HServerModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务器组件工具(银色软件)";
            this.DangerModuleGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UnRegAllButton;
        private System.Windows.Forms.Button RegAllButton;
        private System.Windows.Forms.GroupBox DangerModuleGroupBox;
    }
}

