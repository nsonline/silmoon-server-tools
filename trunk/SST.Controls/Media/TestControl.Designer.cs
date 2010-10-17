namespace SST.Controls.Media
{
    partial class TestControl
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
            this.OpenDefaultMuisc = new System.Windows.Forms.Button();
            this.smTrackBar1 = new Silmoon.Windows.Controls.SmTrackBar();
            this.ctlPlayTipLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenDefaultMuisc
            // 
            this.OpenDefaultMuisc.Location = new System.Drawing.Point(3, 3);
            this.OpenDefaultMuisc.Name = "OpenDefaultMuisc";
            this.OpenDefaultMuisc.Size = new System.Drawing.Size(128, 23);
            this.OpenDefaultMuisc.TabIndex = 0;
            this.OpenDefaultMuisc.Text = "测试音乐播放(&S)";
            this.OpenDefaultMuisc.UseVisualStyleBackColor = true;
            this.OpenDefaultMuisc.Click += new System.EventHandler(this.OpenDefaultMuisc_Click);
            // 
            // smTrackBar1
            // 
            this.smTrackBar1.BackColor = System.Drawing.Color.White;
            this.smTrackBar1.Location = new System.Drawing.Point(3, 32);
            this.smTrackBar1.Name = "smTrackBar1";
            this.smTrackBar1.ProgressPercentage = 0;
            this.smTrackBar1.Size = new System.Drawing.Size(604, 10);
            this.smTrackBar1.TabIndex = 1;
            this.smTrackBar1.Value = 0;
            // 
            // ctlPlayTipLabel
            // 
            this.ctlPlayTipLabel.AutoSize = true;
            this.ctlPlayTipLabel.Location = new System.Drawing.Point(137, 8);
            this.ctlPlayTipLabel.Name = "ctlPlayTipLabel";
            this.ctlPlayTipLabel.Size = new System.Drawing.Size(0, 12);
            this.ctlPlayTipLabel.TabIndex = 2;
            // 
            // TestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctlPlayTipLabel);
            this.Controls.Add(this.smTrackBar1);
            this.Controls.Add(this.OpenDefaultMuisc);
            this.Name = "TestControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenDefaultMuisc;
        private Silmoon.Windows.Controls.SmTrackBar smTrackBar1;
        private System.Windows.Forms.Label ctlPlayTipLabel;
    }
}
