namespace DuplicateFiles
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.lbGroup = new System.Windows.Forms.ListBox();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblLastWriteTime = new System.Windows.Forms.Label();
            this.lblCreationTime = new System.Windows.Forms.Label();
            this.lblSizeValue = new System.Windows.Forms.Label();
            this.lblLastWriteTimeValue = new System.Windows.Forms.Label();
            this.lblCreationTimeValue = new System.Windows.Forms.Label();
            this.lblGroupCount = new System.Windows.Forms.Label();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Font = new System.Drawing.Font("宋体", 12F);
            this.btnOpen.Location = new System.Drawing.Point(703, 141);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(178, 55);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开文件夹";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lbGroup
            // 
            this.lbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbGroup.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGroup.FormattingEnabled = true;
            this.lbGroup.ItemHeight = 16;
            this.lbGroup.Location = new System.Drawing.Point(12, 28);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(301, 404);
            this.lbGroup.TabIndex = 1;
            this.lbGroup.TabStop = false;
            this.lbGroup.SelectedIndexChanged += new System.EventHandler(this.lbGroup_SelectedIndexChanged);
            // 
            // lbFiles
            // 
            this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiles.Font = new System.Drawing.Font("宋体", 12F);
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 16;
            this.lbFiles.Location = new System.Drawing.Point(319, 28);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(366, 404);
            this.lbFiles.TabIndex = 2;
            this.lbFiles.TabStop = false;
            this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
            this.lbFiles.DoubleClick += new System.EventHandler(this.lbFiles_DoubleClick);
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("宋体", 12F);
            this.lblSize.Location = new System.Drawing.Point(697, 30);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(72, 16);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "文件大小";
            // 
            // lblLastWriteTime
            // 
            this.lblLastWriteTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastWriteTime.AutoSize = true;
            this.lblLastWriteTime.Font = new System.Drawing.Font("宋体", 12F);
            this.lblLastWriteTime.Location = new System.Drawing.Point(697, 83);
            this.lblLastWriteTime.Name = "lblLastWriteTime";
            this.lblLastWriteTime.Size = new System.Drawing.Size(72, 16);
            this.lblLastWriteTime.TabIndex = 3;
            this.lblLastWriteTime.Text = "修改时间";
            // 
            // lblCreationTime
            // 
            this.lblCreationTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreationTime.AutoSize = true;
            this.lblCreationTime.Font = new System.Drawing.Font("宋体", 12F);
            this.lblCreationTime.Location = new System.Drawing.Point(697, 55);
            this.lblCreationTime.Name = "lblCreationTime";
            this.lblCreationTime.Size = new System.Drawing.Size(72, 16);
            this.lblCreationTime.TabIndex = 3;
            this.lblCreationTime.Text = "创建时间";
            // 
            // lblSizeValue
            // 
            this.lblSizeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSizeValue.AutoSize = true;
            this.lblSizeValue.Font = new System.Drawing.Font("宋体", 12F);
            this.lblSizeValue.Location = new System.Drawing.Point(776, 30);
            this.lblSizeValue.Name = "lblSizeValue";
            this.lblSizeValue.Size = new System.Drawing.Size(0, 16);
            this.lblSizeValue.TabIndex = 3;
            // 
            // lblLastWriteTimeValue
            // 
            this.lblLastWriteTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastWriteTimeValue.AutoSize = true;
            this.lblLastWriteTimeValue.Font = new System.Drawing.Font("宋体", 12F);
            this.lblLastWriteTimeValue.Location = new System.Drawing.Point(776, 83);
            this.lblLastWriteTimeValue.Name = "lblLastWriteTimeValue";
            this.lblLastWriteTimeValue.Size = new System.Drawing.Size(0, 16);
            this.lblLastWriteTimeValue.TabIndex = 3;
            // 
            // lblCreationTimeValue
            // 
            this.lblCreationTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreationTimeValue.AutoSize = true;
            this.lblCreationTimeValue.Font = new System.Drawing.Font("宋体", 12F);
            this.lblCreationTimeValue.Location = new System.Drawing.Point(776, 55);
            this.lblCreationTimeValue.Name = "lblCreationTimeValue";
            this.lblCreationTimeValue.Size = new System.Drawing.Size(0, 16);
            this.lblCreationTimeValue.TabIndex = 3;
            // 
            // lblGroupCount
            // 
            this.lblGroupCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGroupCount.AutoSize = true;
            this.lblGroupCount.Font = new System.Drawing.Font("宋体", 12F);
            this.lblGroupCount.Location = new System.Drawing.Point(12, 433);
            this.lblGroupCount.Name = "lblGroupCount";
            this.lblGroupCount.Size = new System.Drawing.Size(0, 16);
            this.lblGroupCount.TabIndex = 4;
            // 
            // lblFileCount
            // 
            this.lblFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Font = new System.Drawing.Font("宋体", 12F);
            this.lblFileCount.Location = new System.Drawing.Point(332, 433);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(0, 16);
            this.lblFileCount.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("宋体", 12F);
            this.btnBrowse.Location = new System.Drawing.Point(703, 202);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(178, 55);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "打开文件位置";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDelete.Location = new System.Drawing.Point(703, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 55);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除文件";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "组";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(317, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "文件";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("宋体", 12F);
            this.lblTime.Location = new System.Drawing.Point(697, 346);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 16);
            this.lblTime.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 458);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.lblGroupCount);
            this.Controls.Add(this.lblCreationTimeValue);
            this.Controls.Add(this.lblCreationTime);
            this.Controls.Add(this.lblLastWriteTimeValue);
            this.Controls.Add(this.lblLastWriteTime);
            this.Controls.Add(this.lblSizeValue);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnOpen);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox lbGroup;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblLastWriteTime;
        private System.Windows.Forms.Label lblCreationTime;
        private System.Windows.Forms.Label lblSizeValue;
        private System.Windows.Forms.Label lblLastWriteTimeValue;
        private System.Windows.Forms.Label lblCreationTimeValue;
        private System.Windows.Forms.Label lblGroupCount;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
    }
}

