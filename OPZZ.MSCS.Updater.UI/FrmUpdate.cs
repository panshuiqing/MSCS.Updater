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
using System.Threading;

namespace OPZZ.MSCS.Updater.UI
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }


        BindingSource bindingSource;
        public ServerConfig Config { get; set; }

        SynchronizationContext synchronizationContext;

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            gridFiles.AutoGenerateColumns = false;
            bindingSource = new BindingSource();
            bindingSource.DataSource = new List<UpdateFileInfo>();
            gridFiles.DataSource = bindingSource;
            synchronizationContext = SynchronizationContext.Current;
        }

        private void BtnPubRemark_Click(object sender, EventArgs e)
        {
            FrmPubRemark frm = new FrmPubRemark();
            frm.ShowDialog(this);
        }

        private void BtnClearFile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要清除文件吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bindingSource.Clear();
            }            
        }

        private void BtnUploadFtp_Click(object sender, EventArgs e)
        {
            try
            {
                var updateFiles = bindingSource.DataSource as List<UpdateFileInfo>;
                if (updateFiles.Count == 0)
                {
                    MessageBox.Show("没有需要上传的文件");
                    return;
                }

                var task = Task.Factory.StartNew(() =>
                {
                    synchronizationContext.Post(UpdateLog, "开始上传文件到FTP...");
                    var ftpHelper = new FtpHelper(FtpConfig.FromConfiguration());
                    var tempFolder = DateTime.Now.ToString("yyyyMMddHHmm");
                    foreach (var file in updateFiles)
                    {
                        var remotePath = Path.Combine(ftpHelper.FtpRootPath, tempFolder, file.RelativePath);
                        ftpHelper.Client.UploadFile(file.FilePath, remotePath, FluentFTP.FtpExists.Overwrite, true);
                        file.FtpPath = remotePath.Replace("\\", "/");
                        synchronizationContext.Post(UpdateLog, $"上传文件 {file.RelativePath} 成功！");
                    }
                });
                task.ContinueWith((t) =>
                {
                    synchronizationContext.Post(UpdateLog, "上传完成...");
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("上传文件到FTP异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 升级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var updateFiles = bindingSource.DataSource as List<UpdateFileInfo>;
                if (updateFiles.Count == 0)
                {
                    MessageBox.Show("没有需要升级的文件");
                    return;
                }

                UpdateClient client = new UpdateClient();
                client.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show("上传文件到FTP异常：" + ex.Message);
            }
        }

        private void GridFiles_DragDrop(object sender, DragEventArgs e)
        {
            var filterList = AppContext.FilterList.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            var filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (filePaths != null && filePaths.Length > 0)
            {
                var updateFiles = bindingSource.DataSource as List<UpdateFileInfo>;
                foreach (var item in filePaths)
                {
                    if (filterList.Any(x => item.Contains(x)))
                    {
                        continue;
                    }

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
                    fileInfo.RelativePath = item.Replace(this.Config.ClientRootPath, "").Replace("\\", "/");

                    bindingSource.Add(fileInfo);
                }
            }
        }

        private void GridFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        public void LoadConfig()
        {
            if (this.Config != null)
            {
                this.txtName.Text = Config.Name;
                this.txtClientRootPath.Text = Config.ClientRootPath;
                this.txtServerAddress.Text = Config.ServerAddress;
                this.txtServerRootPath.Text = Config.ServerRootPath;
            }
        }

        private void UpdateLog(object state)
        {
            if (txtLog.Lines.Length > 5000)
            {
                txtLog.Clear();
            }

            txtLog.AppendText(string.Format("{0} - {1}{2}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff"),
                state, Environment.NewLine));
            txtLog.ScrollToCaret();
        }
    }
}
