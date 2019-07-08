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
    public partial class FrmWeixinRobot : Form
    {
        public FrmWeixinRobot()
        {
            InitializeComponent();
        }

        private void FrmWeixinRobot_Load(object sender, EventArgs e)
        {
            dvList.AutoGenerateColumns = false;

            try
            {
                LoadRobot();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载微信机器人失败：" + ex.ToString());
            }
        }

        private void DvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colDel.Index)
            {
                if (MessageBox.Show("确定要删除吗？", "删除提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                
                try
                {
                    var robot = dvList.CurrentRow.DataBoundItem as WeixinRobot;
                    WeixinRobot.Delete(robot.Id);
                    LoadRobot();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除微信机器人失败：" + ex.ToString());
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var url = txtUrl.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("名称不能为空");
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("地址不能为空");
                txtUrl.Focus();
                return;
            }

            try
            {
                WeixinRobot robot = new WeixinRobot();
                robot.Name = name;
                robot.Url = url;
                WeixinRobot.Insert(robot);
                LoadRobot();
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加微信机器人失败：" + ex.ToString());
            }
        }

        private void LoadRobot()
        {
            dvList.DataSource = WeixinRobot.GetList();
        }
    }
}
