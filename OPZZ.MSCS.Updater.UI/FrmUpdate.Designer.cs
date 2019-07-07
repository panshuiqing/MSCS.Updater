namespace OPZZ.MSCS.Updater.UI
{
    partial class FrmUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridFiles = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnUploadFtp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnPubRemark = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFiles)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(653, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridFiles);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件列表 - 支持拖放";
            // 
            // gridFiles
            // 
            this.gridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFiles.Location = new System.Drawing.Point(3, 17);
            this.gridFiles.Name = "gridFiles";
            this.gridFiles.RowTemplate.Height = 23;
            this.gridFiles.Size = new System.Drawing.Size(653, 191);
            this.gridFiles.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddFile, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUploadFtp, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPubRemark, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(653, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddFile.Location = new System.Drawing.Point(346, 0);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(94, 37);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "添加文件";
            this.toolTip1.SetToolTip(this.btnAddFile, "添加文件到列表");
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // btnUploadFtp
            // 
            this.btnUploadFtp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUploadFtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUploadFtp.Location = new System.Drawing.Point(446, 0);
            this.btnUploadFtp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnUploadFtp.Name = "btnUploadFtp";
            this.btnUploadFtp.Size = new System.Drawing.Size(94, 37);
            this.btnUploadFtp.TabIndex = 0;
            this.btnUploadFtp.Text = "上传FTP";
            this.toolTip1.SetToolTip(this.btnUploadFtp, "上传文件到FTP");
            this.btnUploadFtp.UseVisualStyleBackColor = true;
            this.btnUploadFtp.Click += new System.EventHandler(this.BtnUploadFtp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(546, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 37);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "升级";
            this.toolTip1.SetToolTip(this.btnUpdate, "发送升级指令到服务器");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLog);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(659, 116);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "日志";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 17);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(653, 96);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // btnPubRemark
            // 
            this.btnPubRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPubRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPubRemark.Location = new System.Drawing.Point(246, 0);
            this.btnPubRemark.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnPubRemark.Name = "btnPubRemark";
            this.btnPubRemark.Size = new System.Drawing.Size(94, 37);
            this.btnPubRemark.TabIndex = 0;
            this.btnPubRemark.Text = "发布说明";
            this.toolTip1.SetToolTip(this.btnPubRemark, "将发布说明发送到企业微信机器人");
            this.btnPubRemark.UseVisualStyleBackColor = true;
            this.btnPubRemark.Click += new System.EventHandler(this.BtnPubRemark_Click);
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 487);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpdate";
            this.Text = "FrmUpdate";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFiles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnUploadFtp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnPubRemark;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}