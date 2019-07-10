namespace OPZZ.MSCS.Updater.UI
{
    partial class FrmUpdateHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateHistory));
            this.dvList = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublishAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dvList
            // 
            this.dvList.AllowUserToAddRows = false;
            this.dvList.AllowUserToDeleteRows = false;
            this.dvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvList.ColumnHeadersHeight = 30;
            this.dvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colFileCount,
            this.colPublishAt});
            this.dvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvList.Location = new System.Drawing.Point(0, 0);
            this.dvList.Name = "dvList";
            this.dvList.ReadOnly = true;
            this.dvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvList.RowHeadersVisible = false;
            this.dvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvList.RowTemplate.Height = 25;
            this.dvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvList.Size = new System.Drawing.Size(756, 398);
            this.dvList.TabIndex = 4;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "ServerConfigName";
            this.colName.HeaderText = "发版服务端";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colFileCount
            // 
            this.colFileCount.DataPropertyName = "FileCount";
            this.colFileCount.HeaderText = "文件更新数";
            this.colFileCount.Name = "colFileCount";
            this.colFileCount.ReadOnly = true;
            this.colFileCount.Width = 200;
            // 
            // colPublishAt
            // 
            this.colPublishAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPublishAt.DataPropertyName = "PublishAt";
            this.colPublishAt.HeaderText = "发版时间";
            this.colPublishAt.Name = "colPublishAt";
            this.colPublishAt.ReadOnly = true;
            // 
            // FrmUpdateHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 398);
            this.Controls.Add(this.dvList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpdateHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发版历史";
            this.Load += new System.EventHandler(this.FrmWeixinRobot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublishAt;
    }
}