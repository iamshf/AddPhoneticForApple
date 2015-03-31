namespace AddPhonetic
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labSelectFile = new System.Windows.Forms.Label();
            this.labSavePath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labSelectFile
            // 
            this.labSelectFile.AutoSize = true;
            this.labSelectFile.Location = new System.Drawing.Point(36, 42);
            this.labSelectFile.Name = "labSelectFile";
            this.labSelectFile.Size = new System.Drawing.Size(65, 12);
            this.labSelectFile.TabIndex = 0;
            this.labSelectFile.Text = "选择文件：";
            // 
            // labSavePath
            // 
            this.labSavePath.AutoSize = true;
            this.labSavePath.Location = new System.Drawing.Point(12, 75);
            this.labSavePath.Name = "labSavePath";
            this.labSavePath.Size = new System.Drawing.Size(89, 12);
            this.labSavePath.TabIndex = 1;
            this.labSavePath.Text = "选择保存位置：";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(108, 39);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(465, 21);
            this.txtFilePath.TabIndex = 2;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(108, 72);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(465, 21);
            this.txtSavePath.TabIndex = 3;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(579, 37);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(114, 23);
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(579, 70);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(114, 23);
            this.btnSavePath.TabIndex = 5;
            this.btnSavePath.Text = "选择保存位置";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(279, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "开始添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 431);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.labSavePath);
            this.Controls.Add(this.labSelectFile);
            this.Name = "Form1";
            this.Text = "为iCloud通讯录批量添加拼音";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labSelectFile;
        private System.Windows.Forms.Label labSavePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.Button btnAdd;
    }
}

