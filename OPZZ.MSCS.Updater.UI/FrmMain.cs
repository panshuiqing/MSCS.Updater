using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
