using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPZZ.MSCS.Updater.Core;

namespace OPZZ.MSCS.Updater.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmUpdate serverSetting = new FrmUpdate();
            serverSetting.TopLevel = false;
            serverSetting.Dock = DockStyle.Fill;
            serverSetting.Parent = splitContainer1.Panel2;
            serverSetting.Show();

            this.LoadGroup();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemAddGroup_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemEditGroup_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemAddServer_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemEditServer_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemDelServer_Click(object sender, EventArgs e)
        {

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
            }
        }
    }
}
