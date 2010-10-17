namespace SST.Ext.Tools
{
    partial class ScanCodeOptionWindow
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
            this.ctlComfirmButton = new System.Windows.Forms.Button();
            this.ctlFileSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctlFileSizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlComfirmButton
            // 
            this.ctlComfirmButton.Location = new System.Drawing.Point(296, 128);
            this.ctlComfirmButton.Name = "ctlComfirmButton";
            this.ctlComfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ctlComfirmButton.TabIndex = 0;
            this.ctlComfirmButton.Text = "确定(&A)";
            this.ctlComfirmButton.UseVisualStyleBackColor = true;
            this.ctlComfirmButton.Click += new System.EventHandler(this.ctlComfirmButton_Click);
            // 
            // ctlFileSizeUpDown
            // 
            this.ctlFileSizeUpDown.Location = new System.Drawing.Point(181, 51);
            this.ctlFileSizeUpDown.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.ctlFileSizeUpDown.Name = "ctlFileSizeUpDown";
            this.ctlFileSizeUpDown.Size = new System.Drawing.Size(95, 21);
            this.ctlFileSizeUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "扫描文件最大尺寸:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(179, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "0 表示不检查大小";
            // 
            // ScanCodeOptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 163);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlFileSizeUpDown);
            this.Controls.Add(this.ctlComfirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ScanCodeOptionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码扫描选项";
            this.Load += new System.EventHandler(this.ScanCodeOptionWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlFileSizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ctlFileSizeUpDown;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Button ctlComfirmButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}