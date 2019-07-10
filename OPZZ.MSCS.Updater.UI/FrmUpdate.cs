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

                txtLog.Clear();

                var task = Task.Factory.StartNew(() =>
                {
                    try
                    {
                        synchronizationContext.Post(UpdateLog, "开始上传文件到FTP...");
                        var ftpHelper = new FtpHelper(FtpConfig.FromConfiguration());
                        var tempFolder = DateTime.Now.ToString("yyyyMMddHHmm");
                        foreach (var file in updateFiles)
                        {
                            var remotePath = Path.Combine(ftpHelper.FtpRootPath, tempFolder, file.RelativePath);
                            ftpHelper.Client.UploadFile(file.FilePath, remotePath, FluentFTP.FtpExists.Overwrite, true);
                            file.FtpPath = remotePath;
                            synchronizationContext.Post(UpdateLog, $"上传文件 {file.RelativePath} 成功！");
                        }
                    }
                    catch (Exception err)
                    {
                        synchronizationContext.Post(UpdateLog, "上传文件异常：" + err.StackTrace);
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
        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateClient client = null;
            try
            {
                var updateFiles = bindingSource.DataSource as List<UpdateFileInfo>;
                if (updateFiles.Count == 0)
                {
                    MessageBox.Show("没有需要升级的文件");
                    return;
                }

                if (updateFiles.Any(x => string.IsNullOrEmpty(x.FtpPath)))
                {
                    MessageBox.Show("请先将文件上传至FTP");
                    return;
                }

                txtLog.Text = string.Empty;

                var data = new UpdateData { Config = this.Config, Files = updateFiles.ToArray() };
                UpdaterClientHandler handler = new UpdaterClientHandler();
                handler.ReceiveMessage += Handler_ReceiveMessage;
                client = new UpdateClient(handler);
                await client.Connect(this.Config.ServerAddress);                
                await client.Send(JsonHelper.ToJson(data));
            }
            catch (Exception ex)
            {
                client?.Stop();
                MessageBox.Show("上传文件到FTP异常：" + ex.Message);
            }
        }

        private void Handler_ReceiveMessage(object sender, UpdaterClientEventArgs e)
        {
            synchronizationContext.Post(UpdateLog, e.Message);
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

                    if (!item.StartsWith(this.Config.ClientRootPath))
                    {
                        UpdateLog($"文件 {item}不在客户端根目录下，无法添加");
                        continue;
                    }

                    var fileInfo = new UpdateFileInfo();
                    fileInfo.FilePath = item;
                    fileInfo.RelativePath = item.Replace(this.Config.ClientRootPath, "").TrimStart('\\');

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

        private void MenuItemDelFile_Click(object sender, EventArgs e)
        {
            if (gridFiles.CurrentRow != null)
            {
                var file = gridFiles.CurrentRow.DataBoundItem as UpdateFileInfo;
                if (file != null)
                {
                    bindingSource.Remove(file);
                }
            }
        }

        private void MenuItemClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }
    }
}
