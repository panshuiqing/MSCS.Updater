namespace OPZZ.MSCS.Updater.UI
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvServers = new System.Windows.Forms.TreeView();
            this.contextMenuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAddServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBobot = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuTree.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvServers);
            this.splitContainer1.Size = new System.Drawing.Size(984, 577);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvServers
            // 
            this.tvServers.ContextMenuStrip = this.contextMenuTree;
            this.tvServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvServers.Location = new System.Drawing.Point(0, 0);
            this.tvServers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tvServers.Name = "tvServers";
            this.tvServers.Size = new System.Drawing.Size(264, 577);
            this.tvServers.TabIndex = 0;
            this.tvServers.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvServers_NodeMouseDoubleClick);
            // 
            // contextMenuTree
            // 
            this.contextMenuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddGroup,
            this.menuItemEditGroup,
            this.toolStripSeparator1,
            this.menuItemAddServer,
            this.menuItemEditServer,
            this.menuItemDelServer});
            this.contextMenuTree.Name = "contextMenuTree";
            this.contextMenuTree.Size = new System.Drawing.Size(137, 120);
            this.contextMenuTree.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuTree_Opening);
            // 
            // menuItemAddGroup
            // 
            this.menuItemAddGroup.Name = "menuItemAddGroup";
            this.menuItemAddGroup.Size = new System.Drawing.Size(136, 22);
            this.menuItemAddGroup.Text = "添加分组";
            this.menuItemAddGroup.Click += new System.EventHandler(this.MenuItemAddGroup_Click);
            // 
            // menuItemEditGroup
            // 
            this.menuItemEditGroup.Name = "menuItemEditGroup";
            this.menuItemEditGroup.Size = new System.Drawing.Size(136, 22);
            this.menuItemEditGroup.Text = "修改分组";
            this.menuItemEditGroup.Click += new System.EventHandler(this.MenuItemEditGroup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // menuItemAddServer
            // 
            this.menuItemAddServer.Name = "menuItemAddServer";
            this.menuItemAddServer.Size = new System.Drawing.Size(136, 22);
            this.menuItemAddServer.Text = "添加服务器";
            this.menuItemAddServer.Click += new System.EventHandler(this.MenuItemAddServer_Click);
            // 
            // menuItemEditServer
            // 
            this.menuItemEditServer.Name = "menuItemEditServer";
            this.menuItemEditServer.Size = new System.Drawing.Size(136, 22);
            this.menuItemEditServer.Text = "修改服务器";
            this.menuItemEditServer.Click += new System.EventHandler(this.MenuItemEditServer_Click);
            // 
            // menuItemDelServer
            // 
            this.menuItemDelServer.Name = "menuItemDelServer";
            this.menuItemDelServer.Size = new System.Drawing.Size(136, 22);
            this.menuItemDelServer.Text = "删除服务器";
            this.menuItemDelServer.Click += new System.EventHandler(this.MenuItemDelServer_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBobot,
            this.toolStripSeparator2,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBobot
            // 
            this.btnBobot.Image = ((System.Drawing.Image)(resources.GetObject("btnBobot.Image")));
            this.btnBobot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBobot.Name = "btnBobot";
            this.btnBobot.Size = new System.Drawing.Size(112, 22);
            this.btnBobot.Text = "设置微信机器人";
            this.btnBobot.Click += new System.EventHandler(this.BtnBobot_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 22);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 602);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSCS升级辅助工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuTree.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvServers;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBobot;
        private System.Windows.Forms.ContextMenuStrip contextMenuTree;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddGroup;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditServer;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelServer;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
    }
}

