﻿namespace SST.Ext.IIS.Performance
{
    partial class ApplicationPoolInputBox
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
            this.ctlNameTextBox = new System.Windows.Forms.TextBox();
            this.ctlComfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctlNameTextBox
            // 
            this.ctlNameTextBox.Location = new System.Drawing.Point(33, 47);
            this.ctlNameTextBox.Name = "ctlNameTextBox";
            this.ctlNameTextBox.Size = new System.Drawing.Size(266, 21);
            this.ctlNameTextBox.TabIndex = 0;
            this.ctlNameTextBox.TextChanged += new System.EventHandler(this.ctlNameTextBox_TextChanged);
            // 
            // ctlComfirmButton
            // 
            this.ctlComfirmButton.Location = new System.Drawing.Point(210, 74);
            this.ctlComfirmButton.Name = "ctlComfirmButton";
            this.ctlComfirmButton.Size = new System.Drawing.Size(89, 29);
            this.ctlComfirmButton.TabIndex = 1;
            this.ctlComfirmButton.Text = "确定";
            this.ctlComfirmButton.UseVisualStyleBackColor = true;
            this.ctlComfirmButton.Click += new System.EventHandler(this.ctlComfirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ApplicationPoolsInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 117);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlComfirmButton);
            this.Controls.Add(this.ctlNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationPoolsInputBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定义名称";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctlNameTextBox;
        private System.Windows.Forms.Button ctlComfirmButton;
        private System.Windows.Forms.Label label1;
    }
}