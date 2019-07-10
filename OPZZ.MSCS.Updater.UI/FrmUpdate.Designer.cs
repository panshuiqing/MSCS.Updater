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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.txtClientRootPath = new System.Windows.Forms.TextBox();
            this.txtServerRootPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridFiles = new System.Windows.Forms.DataGridView();
            this.colRelativePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFtpPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPubRemark = new System.Windows.Forms.Button();
            this.btnClearFile = new System.Windows.Forms.Button();
            this.btnUploadFtp = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFiles)).BeginInit();
            this.contextMenuFiles.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtServerAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtClientRootPath, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtServerRootPath, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(653, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户端名称：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "服务端地址：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "客户端根目录：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "服务端根目录：";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(91, 1);
            this.txtName.Margin = new System.Windows.Forms.Padding(1);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(229, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerAddress.Location = new System.Drawing.Point(91, 28);
            this.txtServerAddress.Margin = new System.Windows.Forms.Padding(1);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.ReadOnly = true;
            this.txtServerAddress.Size = new System.Drawing.Size(229, 21);
            this.txtServerAddress.TabIndex = 1;
            // 
            // txtClientRootPath
            // 
            this.txtClientRootPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClientRootPath.Location = new System.Drawing.Point(422, 1);
            this.txtClientRootPath.Margin = new System.Windows.Forms.Padding(1);
            this.txtClientRootPath.Name = "txtClientRootPath";
            this.txtClientRootPath.ReadOnly = true;
            this.txtClientRootPath.Size = new System.Drawing.Size(230, 21);
            this.txtClientRootPath.TabIndex = 1;
            // 
            // txtServerRootPath
            // 
            this.txtServerRootPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerRootPath.Location = new System.Drawing.Point(422, 28);
            this.txtServerRootPath.Margin = new System.Windows.Forms.Padding(1);
            this.txtServerRootPath.Name = "txtServerRootPath";
            this.txtServerRootPath.ReadOnly = true;
            this.txtServerRootPath.Size = new System.Drawing.Size(230, 21);
            this.txtServerRootPath.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridFiles);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件列表 - 支持拖放";
            // 
            // gridFiles
            // 
            this.gridFiles.AllowDrop = true;
            this.gridFiles.AllowUserToAddRows = false;
            this.gridFiles.AllowUserToDeleteRows = false;
            this.gridFiles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRelativePath,
            this.colFtpPath});
            this.gridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFiles.Location = new System.Drawing.Point(3, 17);
            this.gridFiles.Name = "gridFiles";
            this.gridFiles.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridFiles.RowHeadersVisible = false;
            this.gridFiles.RowTemplate.ContextMenuStrip = this.contextMenuFiles;
            this.gridFiles.RowTemplate.Height = 23;
            this.gridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFiles.Size = new System.Drawing.Size(653, 225);
            this.gridFiles.TabIndex = 0;
            this.gridFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.GridFiles_DragDrop);
            this.gridFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.GridFiles_DragEnter);
            // 
            // colRelativePath
            // 
            this.colRelativePath.DataPropertyName = "RelativePath";
            this.colRelativePath.HeaderText = "文件名(相对路径)";
            this.colRelativePath.MinimumWidth = 200;
            this.colRelativePath.Name = "colRelativePath";
            this.colRelativePath.ReadOnly = true;
            this.colRelativePath.Width = 350;
            // 
            // colFtpPath
            // 
            this.colFtpPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFtpPath.DataPropertyName = "FtpPath";
            this.colFtpPath.HeaderText = "Ftp路径(相对)";
            this.colFtpPath.Name = "colFtpPath";
            this.colFtpPath.ReadOnly = true;
            // 
            // contextMenuFiles
            // 
            this.contextMenuFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDelFile});
            this.contextMenuFiles.Name = "contextMenuFiles";
            this.contextMenuFiles.Size = new System.Drawing.Size(125, 26);
            // 
            // menuItemDelFile
            // 
            this.menuItemDelFile.Name = "menuItemDelFile";
            this.menuItemDelFile.Size = new System.Drawing.Size(124, 22);
            this.menuItemDelFile.Text = "删除文件";
            this.menuItemDelFile.Click += new System.EventHandler(this.MenuItemDelFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPubRemark, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClearFile, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUploadFtp, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(653, 40);
            this.tableLayoutPanel2.TabIndex = 0;
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
            // btnPubRemark
            // 
            this.btnPubRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPubRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPubRemark.Location = new System.Drawing.Point(3, 0);
            this.btnPubRemark.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnPubRemark.Name = "btnPubRemark";
            this.btnPubRemark.Size = new System.Drawing.Size(94, 37);
            this.btnPubRemark.TabIndex = 0;
            this.btnPubRemark.Text = "发布说明";
            this.toolTip1.SetToolTip(this.btnPubRemark, "将发布说明发送到企业微信机器人");
            this.btnPubRemark.UseVisualStyleBackColor = true;
            this.btnPubRemark.Click += new System.EventHandler(this.BtnPubRemark_Click);
            // 
            // btnClearFile
            // 
            this.btnClearFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearFile.Location = new System.Drawing.Point(103, 0);
            this.btnClearFile.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnClearFile.Name = "btnClearFile";
            this.btnClearFile.Size = new System.Drawing.Size(94, 37);
            this.btnClearFile.TabIndex = 0;
            this.btnClearFile.Text = "清除文件";
            this.toolTip1.SetToolTip(this.btnClearFile, "添加文件到列表");
            this.btnClearFile.UseVisualStyleBackColor = true;
            this.btnClearFile.Click += new System.EventHandler(this.BtnClearFile_Click);
            // 
            // btnUploadFtp
            // 
            this.btnUploadFtp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUploadFtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUploadFtp.Location = new System.Drawing.Point(203, 0);
            this.btnUploadFtp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnUploadFtp.Name = "btnUploadFtp";
            this.btnUploadFtp.Size = new System.Drawing.Size(94, 37);
            this.btnUploadFtp.TabIndex = 0;
            this.btnUploadFtp.Text = "上传FTP";
            this.toolTip1.SetToolTip(this.btnUploadFtp, "上传文件到FTP");
            this.btnUploadFtp.UseVisualStyleBackColor = true;
            this.btnUploadFtp.Click += new System.EventHandler(this.BtnUploadFtp_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLog);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 379);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(659, 108);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "日志";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLog.ContextMenuStrip = this.contextMenuLog;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(3, 17);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(653, 88);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // contextMenuLog
            // 
            this.contextMenuLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemClearLog});
            this.contextMenuLog.Name = "contextMenuLog";
            this.contextMenuLog.Size = new System.Drawing.Size(125, 26);
            // 
            // menuItemClearLog
            // 
            this.menuItemClearLog.Name = "menuItemClearLog";
            this.menuItemClearLog.Size = new System.Drawing.Size(124, 22);
            this.menuItemClearLog.Text = "清除日志";
            this.menuItemClearLog.Click += new System.EventHandler(this.MenuItemClearLog_Click);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFiles)).EndInit();
            this.contextMenuFiles.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.contextMenuLog.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnClearFile;
        private System.Windows.Forms.Button btnUploadFtp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnPubRemark;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.TextBox txtClientRootPath;
        private System.Windows.Forms.TextBox txtServerRootPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRelativePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFtpPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuFiles;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuLog;
        private System.Windows.Forms.ToolStripMenuItem menuItemClearLog;
    }
}