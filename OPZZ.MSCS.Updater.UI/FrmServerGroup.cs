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
    public partial class FrmServerGroup : Form
    {
        public FrmServerGroup()
        {
            InitializeComponent();
        }

        public bool IsEdit { get; set; }

        public ServerGroup Group { get; set; }

        private void FrmServerGroup_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "分组 - " + (IsEdit ? "修改" : "新增");
                if (IsEdit)
                {
                    txtName.Text = Group.Name;
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

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("分组名称不能为空");
                txtName.Focus();
                return;
            }

            try
            {
                if (IsEdit)
                {
                    this.Group.Name = name;
                    ServerGroup.Update(this.Group);
                }
                else
                {
                    ServerGroup.Insert(new ServerGroup { Name = name });
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
