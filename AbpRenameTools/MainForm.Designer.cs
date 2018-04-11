namespace AbpRenameTools
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnFolderBrowser = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.lblOrgName = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.tbOrgName = new System.Windows.Forms.TextBox();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.tbFilterFileExt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuilder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbChildDir = new System.Windows.Forms.TextBox();
            this.tbFilterPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 259);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(608, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnFolderBrowser
            // 
            this.btnFolderBrowser.Location = new System.Drawing.Point(12, 22);
            this.btnFolderBrowser.Name = "btnFolderBrowser";
            this.btnFolderBrowser.Size = new System.Drawing.Size(100, 23);
            this.btnFolderBrowser.TabIndex = 1;
            this.btnFolderBrowser.Text = "选择项目路径";
            this.btnFolderBrowser.UseVisualStyleBackColor = true;
            this.btnFolderBrowser.Click += new System.EventHandler(this.btnFolderBrowser_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(118, 23);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(478, 21);
            this.tbFilePath.TabIndex = 2;
            // 
            // lblOrgName
            // 
            this.lblOrgName.AutoSize = true;
            this.lblOrgName.Location = new System.Drawing.Point(12, 69);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(53, 12);
            this.lblOrgName.TabIndex = 3;
            this.lblOrgName.Text = "原名称：";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(12, 109);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(53, 12);
            this.lblNewName.TabIndex = 4;
            this.lblNewName.Text = "新名称：";
            // 
            // tbOrgName
            // 
            this.tbOrgName.Location = new System.Drawing.Point(72, 65);
            this.tbOrgName.Name = "tbOrgName";
            this.tbOrgName.Size = new System.Drawing.Size(524, 21);
            this.tbOrgName.TabIndex = 5;
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(72, 105);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(524, 21);
            this.tbNewName.TabIndex = 6;
            // 
            // tbFilterFileExt
            // 
            this.tbFilterFileExt.Location = new System.Drawing.Point(83, 148);
            this.tbFilterFileExt.Name = "tbFilterFileExt";
            this.tbFilterFileExt.Size = new System.Drawing.Size(513, 21);
            this.tbFilterFileExt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "过滤文件：";
            // 
            // btnBuilder
            // 
            this.btnBuilder.Location = new System.Drawing.Point(521, 220);
            this.btnBuilder.Name = "btnBuilder";
            this.btnBuilder.Size = new System.Drawing.Size(75, 23);
            this.btnBuilder.TabIndex = 9;
            this.btnBuilder.Text = "执行";
            this.btnBuilder.UseVisualStyleBackColor = true;
            this.btnBuilder.Click += new System.EventHandler(this.btnBuilder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "子目录：";
            // 
            // tbChildDir
            // 
            this.tbChildDir.Location = new System.Drawing.Point(72, 220);
            this.tbChildDir.Name = "tbChildDir";
            this.tbChildDir.Size = new System.Drawing.Size(430, 21);
            this.tbChildDir.TabIndex = 11;
            // 
            // tbFilterPath
            // 
            this.tbFilterPath.Location = new System.Drawing.Point(95, 181);
            this.tbFilterPath.Name = "tbFilterPath";
            this.tbFilterPath.Size = new System.Drawing.Size(501, 21);
            this.tbFilterPath.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "过滤文件夹：";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(32, 17);
            this.tsslStatus.Text = "状态";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 281);
            this.Controls.Add(this.tbFilterPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbChildDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuilder);
            this.Controls.Add(this.tbFilterFileExt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.tbOrgName);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.lblOrgName);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.btnFolderBrowser);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABP项目重命名V1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnFolderBrowser;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lblOrgName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox tbOrgName;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.TextBox tbFilterFileExt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuilder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbChildDir;
        private System.Windows.Forms.TextBox tbFilterPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
    }
}

