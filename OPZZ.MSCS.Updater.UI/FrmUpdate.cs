using OPZZ.MSCS.Updater.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OPZZ.MSCS.Updater.UI
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }


        BindingSource bindingSource;

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            gridFiles.AutoGenerateColumns = false;
            bindingSource = new BindingSource();
            bindingSource.DataSource = new List<UpdateFileInfo>();
            gridFiles.DataSource = bindingSource;
        }

        private void BtnPubRemark_Click(object sender, EventArgs e)
        {

        }

        private void BtnClearFile_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
        }

        private void BtnUploadFtp_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void GridFiles_DragDrop(object sender, DragEventArgs e)
        {
            var filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (filePaths != null && filePaths.Length > 0)
            {
                var updateFiles = bindingSource.DataSource as List<UpdateFileInfo>;
                foreach (var item in filePaths)
                {
                    if (!File.Exists(item))
                    {
                        continue;
                    }

                    if (updateFiles.Exists(x => x.FilePath == item))
                    {
                        continue;
                    }

                    var fileInfo = new UpdateFileInfo();
                    fileInfo.FilePath = item;
                    fileInfo.RelativePath = item;

                    bindingSource.Add(fileInfo);
                }
            }
        }

        private void GridFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }
    }
}
