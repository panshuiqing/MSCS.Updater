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

            List<WeixinRobot> lst = new List<WeixinRobot>();
            lst.Add(new WeixinRobot { Id = 1, Name = "sss", Url = "22" });

            dvList.DataSource = lst;
        }

        private void DvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colDel.Index)
            {
                MessageBox.Show("aaa");
            }
        }
    }
}
