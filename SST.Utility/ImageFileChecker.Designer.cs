namespace SST.Utility
{
    partial class ImageFileChecker
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
            this.components = new System.ComponentModel.Container();
            this.ctlResultListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.图片查看器打开IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记事本打开TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件目录DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlCheckFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.ctlBrowserButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlStartCheckButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlResultListView
            // 
            this.ctlResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ctlResultListView.ContextMenuStrip = this.contextMenuStrip1;
            this.ctlResultListView.FullRowSelect = true;
            this.ctlResultListView.HideSelection = false;
            this.ctlResultListView.Location = new System.Drawing.Point(6, 50);
            this.ctlResultListView.Name = "ctlResultListView";
            this.ctlResultListView.Size = new System.Drawing.Size(623, 242);
            this.ctlResultListView.TabIndex = 0;
            this.ctlResultListView.UseCompatibleStateImageBehavior = false;
            this.ctlResultListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "完整路径";
            this.columnHeader2.Width = 380;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "判断根据";
            this.columnHeader3.Width = 115;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图片查看器打开IToolStripMenuItem,
            this.记事本打开TToolStripMenuItem,
            this.打开文件目录DToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 图片查看器打开IToolStripMenuItem
            // 
            this.图片查看器打开IToolStripMenuItem.Name = "图片查看器打开IToolStripMenuItem";
            this.图片查看器打开IToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.图片查看器打开IToolStripMenuItem.Text = "图片查看器打开(&I)";
            this.图片查看器打开IToolStripMenuItem.Click += new System.EventHandler(this.图片查看器打开IToolStripMenuItem_Click);
            // 
            // 记事本打开TToolStripMenuItem
            // 
            this.记事本打开TToolStripMenuItem.Name = "记事本打开TToolStripMenuItem";
            this.记事本打开TToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.记事本打开TToolStripMenuItem.Text = "记事本打开(&T)";
            this.记事本打开TToolStripMenuItem.Click += new System.EventHandler(this.记事本打开TToolStripMenuItem_Click);
            // 
            // 打开文件目录DToolStripMenuItem
            // 
            this.打开文件目录DToolStripMenuItem.Name = "打开文件目录DToolStripMenuItem";
            this.打开文件目录DToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.打开文件目录DToolStripMenuItem.Text = "打开文件目录(&D)";
            this.打开文件目录DToolStripMenuItem.Click += new System.EventHandler(this.打开文件目录DToolStripMenuItem_Click);
            // 
            // ctlCheckFolderPathTextBox
            // 
            this.ctlCheckFolderPathTextBox.Location = new System.Drawing.Point(69, 24);
            this.ctlCheckFolderPathTextBox.Name = "ctlCheckFolderPathTextBox";
            this.ctlCheckFolderPathTextBox.Size = new System.Drawing.Size(479, 21);
            this.ctlCheckFolderPathTextBox.TabIndex = 1;
            // 
            // ctlBrowserButton
            // 
            this.ctlBrowserButton.Location = new System.Drawing.Point(554, 23);
            this.ctlBrowserButton.Name = "ctlBrowserButton";
            this.ctlBrowserButton.Size = new System.Drawing.Size(75, 23);
            this.ctlBrowserButton.TabIndex = 2;
            this.ctlBrowserButton.Text = "...(&B)";
            this.ctlBrowserButton.UseVisualStyleBackColor = true;
            this.ctlBrowserButton.Click += new System.EventHandler(this.ctlBrowserButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ctlStartCheckButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ctlBrowserButton);
            this.groupBox1.Controls.Add(this.ctlCheckFolderPathTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设定";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "本工具对所有具有图片为扩展名的文件进行图片解码，如果有失败的可能不是真实的图片文件！";
            // 
            // ctlStartCheckButton
            // 
            this.ctlStartCheckButton.Location = new System.Drawing.Point(554, 52);
            this.ctlStartCheckButton.Name = "ctlStartCheckButton";
            this.ctlStartCheckButton.Size = new System.Drawing.Size(75, 23);
            this.ctlStartCheckButton.TabIndex = 3;
            this.ctlStartCheckButton.Text = "开始(&S)";
            this.ctlStartCheckButton.UseVisualStyleBackColor = true;
            this.ctlStartCheckButton.Click += new System.EventHandler(this.ctlStartCheckButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "检查目录:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.ctlResultListView);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 298);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结果 （解码失败的文件）";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(554, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 34);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "等待开始...";
            // 
            // ImageFileChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImageFileChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片文件检查工具 （检查以图片扩展名命名的非有效图片格式的文件）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageFileChecker_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ctlResultListView;
        private System.Windows.Forms.TextBox ctlCheckFolderPathTextBox;
        private System.Windows.Forms.Button ctlBrowserButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ctlStartCheckButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 记事本打开TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件目录DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图片查看器打开IToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}