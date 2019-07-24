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
    public partial class FrmServerConfig : Form
    {
        public FrmServerConfig()
        {
            InitializeComponent();
        }

        public bool IsEdit { get; set; }

        public ServerGroup Group { get; set; }

        public ServerConfig Config { get; set; }

        private void FrmServerConfig_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "服务器 - " + (IsEdit ? "修改" : "新增");
                if (IsEdit)
                {
                    txtName.Text = Config.Name;
                    txtClientRootPath.Text = Config.ClientRootPath;
                    txtServerAddress.Text = Config.ServerAddress;
                    txtServerRootPath.Text = Config.ServerRootPath;
                    txtSvnPath.Text = Config.SvnPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载分组失败：" + ex.ToString());
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var clientRootPath = txtClientRootPath.Text.Trim();
            var serverAddress = txtServerAddress.Text.Trim();
            var serverRootPath = txtServerRootPath.Text.Trim();
            var svnPath = txtSvnPath.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("客户端名称不能为空");
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(clientRootPath))
            {
                MessageBox.Show("客户端根目录不能为空");
                txtClientRootPath.Focus();
                return;
            }

            if (string.IsNullOrEmpty(serverAddress))
            {
                MessageBox.Show("服务器地址不能为空");
                txtServerAddress.Focus();
                return;
            }

            if (string.IsNullOrEmpty(serverRootPath))
            {
                MessageBox.Show("服务器根目录不能为空");
                txtServerRootPath.Focus();
                return;
            }

            try
            {
                this.Config.Name = name;
                this.Config.ClientRootPath = clientRootPath;
                this.Config.ServerAddress = serverAddress;
                this.Config.ServerRootPath = serverRootPath;
                this.Config.SvnPath = svnPath;

                if (IsEdit)
                {
                    ServerConfig.Update(this.Config);
                }
                else
                {
                    this.Config.GroupId = Group.Id;
                    ServerConfig.Insert(this.Config);
                }
                MessageBox.Show("保存成功！");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存分组失败：" + ex.ToString());
            }
        }
    }
}
