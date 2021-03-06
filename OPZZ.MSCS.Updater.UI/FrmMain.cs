﻿using OPZZ.MSCS.Updater.Core;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OPZZ.MSCS.Updater.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        FrmUpdate updateForm = new FrmUpdate();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            updateForm = new FrmUpdate();
            updateForm.TopLevel = false;
            updateForm.Dock = DockStyle.Fill;
            updateForm.Parent = splitContainer1.Panel2;            

            this.LoadGroup();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemAddGroup_Click(object sender, EventArgs e)
        {
            FrmServerGroup serverGroup = new FrmServerGroup();
            if (serverGroup.ShowDialog(this) == DialogResult.OK)
            {
                this.LoadGroup();
            }
        }

        private void MenuItemEditGroup_Click(object sender, EventArgs e)
        {
            var group = tvServers.SelectedNode.Tag as ServerGroup;
            if (group != null)
            {
                FrmServerGroup serverGroup = new FrmServerGroup();
                serverGroup.IsEdit = true;
                serverGroup.Group = group;
                if (serverGroup.ShowDialog(this) == DialogResult.OK)
                {
                    this.LoadGroup();
                }
            }            
        }

        private void MenuItemAddServer_Click(object sender, EventArgs e)
        {
            var group = tvServers.SelectedNode.Tag as ServerGroup;
            if (group != null)
            {
                FrmServerConfig form = new FrmServerConfig();
                form.Group = group;
                form.Config = new ServerConfig();
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    this.LoadGroup();
                }
            }
        }

        private void MenuItemEditServer_Click(object sender, EventArgs e)
        {
            var selectedNode = tvServers.SelectedNode;
            var config = selectedNode?.Tag as ServerConfig;
            if (selectedNode != null && config != null)
            {
                FrmServerConfig form = new FrmServerConfig();
                form.Config = config;
                form.IsEdit = true;
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    this.LoadGroup();
                }
            }
        }

        private void MenuItemDelServer_Click(object sender, EventArgs e)
        {
            var selectedNode = tvServers.SelectedNode;
            var config = selectedNode?.Tag as ServerConfig;
            if (selectedNode != null && config != null)
            {
                if (MessageBox.Show($"确定要删除服务器[{config.Name}]吗？", "提升", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ServerConfig.Delete(config.Id);
                    this.LoadGroup();
                }
            }
        }

        private void BtnBobot_Click(object sender, EventArgs e)
        {
            FrmWeixinRobot form = new FrmWeixinRobot();
            form.ShowDialog(this);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadGroup()
        {
            tvServers.Nodes.Clear();
            var groupList = ServerGroup.GetList();
            foreach (var group in groupList)
            {
                var groupNode = new TreeNode();
                groupNode.Text = group.Name;
                groupNode.Tag = group;

                foreach (var config in group.ServerConfigs)
                {
                    var serverNode = new TreeNode();
                    serverNode.Text = config.Name;
                    serverNode.Tag = config;

                    groupNode.Nodes.Add(serverNode);
                }

                tvServers.Nodes.Add(groupNode);
            }
            tvServers.ExpandAll();
            updateForm.Hide();
        }

        private void ContextMenuTree_Opening(object sender, CancelEventArgs e)
        {
            menuItemAddGroup.Enabled = true;
            if (tvServers.SelectedNode != null)
            {
                var nodeData = tvServers.SelectedNode.Tag;
                if (nodeData is ServerGroup)
                {
                    menuItemAddServer.Enabled = true;
                    menuItemEditGroup.Enabled = true;
                    menuItemEditServer.Enabled = false;
                    menuItemDelServer.Enabled = false;
                }
                else
                {
                    menuItemAddServer.Enabled = false;
                    menuItemEditGroup.Enabled = false;
                    menuItemEditServer.Enabled = true;
                    menuItemDelServer.Enabled = true;
                    menuItemAddGroup.Enabled = false;
                }
            }
            else
            {
                menuItemAddServer.Enabled = false;
                menuItemEditGroup.Enabled = false;
                menuItemDelServer.Enabled = false;
                menuItemEditServer.Enabled = false;
            }
        }

        private void TvServers_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (tvServers.SelectedNode != null)
            {
                var nodeData = tvServers.SelectedNode.Tag;
                if (nodeData is ServerConfig)
                {
                    updateForm.Config = (nodeData as ServerConfig);
                    if (!updateForm.Visible)
                    {
                        updateForm.LoadConfig();
                        updateForm.Show();
                    }
                    else
                    {
                        updateForm.LoadConfig();
                    }
                }
            }
        }

        private void BtnPubHistory_Click(object sender, EventArgs e)
        {
            if (tvServers.SelectedNode == null)
            {
                MessageBox.Show("请选择发版服务器");
                return;
            }

            var nodeData = tvServers.SelectedNode.Tag as ServerConfig;
            if (nodeData != null)
            {
                FrmUpdateHistory form = new FrmUpdateHistory();
                form.ServerConfigId = nodeData.Id;
                form.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("请选择发版服务器");
                return;
            }
        }

        private void BtnSvnLog_Click(object sender, EventArgs e)
        {

            if (tvServers.SelectedNode == null)
            {
                MessageBox.Show("请选择发版服务器");
                return;
            }

            try
            {
                var nodeData = tvServers.SelectedNode.Tag as ServerConfig;
                if (nodeData != null)
                {
                    if (string.IsNullOrEmpty(nodeData.SvnPath))
                    {
                        MessageBox.Show("SVN地址不能为空");
                        return;
                    }

                    var lastUpdateDate = UpdateHistory.GetLatest(nodeData.Id).PublishAt;
                    FrmSvnLog frmSvnLog = new FrmSvnLog();
                    frmSvnLog.LastUpdateTime = lastUpdateDate.AddMinutes(-30);
                    frmSvnLog.SvnPath = nodeData.SvnPath;
                    frmSvnLog.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("请选择发版服务器");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取SVN文件异常："+ex.Message);
            }
        }
    }

    
}
