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
    public partial class FrmPubRemark : Form
    {
        public FrmPubRemark()
        {
            InitializeComponent();
        }

        private void FrmPubRemark_Load(object sender, EventArgs e)
        {
            var list = WeixinRobot.GetList();
            int left = 20;
            int top = 25;
            foreach (var item in list)
            {
                CheckBox box = new CheckBox();
                box.AutoSize = true;
                box.Text = item.Name;
                box.TabIndex = 2;
                box.Tag = item;
                box.Checked = true;
                box.Anchor = AnchorStyles.Left;
                box.Left = left;
                box.Top = top;

                left += box.Width + 25;
                gbxRobot.Controls.Add(box);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContent.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("发布内容不能为空");
                    txtContent.Focus();
                    return;
                }

                foreach (var ctrl in gbxRobot.Controls)
                {
                    var checkbox = ctrl as CheckBox;
                    if (checkbox != null && checkbox.Checked)
                    {
                        var url = (checkbox.Tag as WeixinRobot).Url;
                        var msg = new WeixinTexMsg();
                        msg.text.content = txtContent.Text;
                        msg.text.mentioned_list.Add("@all");
                        WeixinPubHelper.PublishText(msg, url);
                    }
                }
                MessageBox.Show("发送成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发布失败：" + ex.ToString());
            }
        }
    }
}
