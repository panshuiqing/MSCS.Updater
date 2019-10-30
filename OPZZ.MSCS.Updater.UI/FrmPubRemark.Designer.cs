namespace OPZZ.MSCS.Updater.UI
{
    partial class FrmPubRemark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPubRemark));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxRobot = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbxRobot);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 376);
            this.panel1.TabIndex = 0;
            // 
            // gbxRobot
            // 
            this.gbxRobot.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxRobot.Location = new System.Drawing.Point(0, 234);
            this.gbxRobot.Name = "gbxRobot";
            this.gbxRobot.Size = new System.Drawing.Size(501, 61);
            this.gbxRobot.TabIndex = 4;
            this.gbxRobot.TabStop = false;
            this.gbxRobot.Text = "微信机器人";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发布内容：";
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.Location = new System.Drawing.Point(3, 17);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(495, 214);
            this.txtContent.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(203, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "发 布";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmPubRemark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 376);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPubRemark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发布说明";
            this.Load += new System.EventHandler(this.FrmPubRemark_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxRobot;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}