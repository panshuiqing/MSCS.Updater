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
    public partial class FrmUpdateHistory : Form
    {
        public FrmUpdateHistory()
        {
            InitializeComponent();
        }

        public int ServerConfigId { get; set; }

        private void FrmWeixinRobot_Load(object sender, EventArgs e)
        {
            try
            {
                dvList.AutoGenerateColumns = false;
                var list = UpdateHistory.GetList(ServerConfigId);
                dvList.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载发版历史失败：" + ex.ToString());
            }
        }
    }
}
