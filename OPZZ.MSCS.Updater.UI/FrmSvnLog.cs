using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPZZ.MSCS.Updater.Core;
using SharpSvn;
using SharpSvn.Security;

namespace OPZZ.MSCS.Updater.UI
{
    public partial class FrmSvnLog : Form
    {
        public FrmSvnLog()
        {
            InitializeComponent();
        }

        public DateTime LastUpdateTime { get; set; }
        public string SvnPath { get; set; }

        private void FrmWeixinRobot_Load(object sender, EventArgs e)
        {
            dvList.AutoGenerateColumns = false;
            txtLastTime.Text = LastUpdateTime.ToString("yyyy-MM-dd HH:mm");
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                var lastTime = DateTime.Parse(txtLastTime.Text.Trim());
                var files = GetSVNFiles(lastTime, SvnPath).OrderBy(x => x.FilePath).ToList();
                dvList.DataSource = files;
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败：" + ex.ToString());
            }
        }

        private IEnumerable<SvnPathInfo> GetSVNFiles(DateTime lastDate, string svnPath)
        {
            IEnumerable<SvnPathInfo> files = new SvnPathInfo[0];

            Uri uriBase = new Uri(svnPath);
            DateTime dtBeg = lastDate.ToUniversalTime();
            DateTime dtEnd = DateTime.Now.AddMinutes(5).ToUniversalTime();
            SvnRevisionRange range = new SvnRevisionRange(dtBeg, dtEnd);
            SvnLogArgs logArgs = new SvnLogArgs(range);
            logArgs.BaseUri = uriBase;
            SvnClient client = new SvnClient();
            client.Authentication.UserNamePasswordHandlers += new EventHandler<SvnUserNamePasswordEventArgs>(Authentication_UserNamePasswordHandlers);

            Collection<SvnLogEventArgs> lstLogEvent = new Collection<SvnLogEventArgs>();
            if (client.GetLog(uriBase, logArgs, out lstLogEvent))
            {
                Dictionary<string, SvnPathInfo> lstFiles = new Dictionary<string, SvnPathInfo>();
                SvnPathInfo pathInfo = null;
                foreach (SvnLogEventArgs log in lstLogEvent)
                {
                    foreach (SvnChangeItem item in log.ChangedPaths)
                    {
                        if (item.NodeKind == SvnNodeKind.File)
                        {
                            if (ContainsExclude(item.Path))
                            {
                                continue;
                            }

                            if (lstFiles.ContainsKey(item.Path))
                            {
                                pathInfo = lstFiles[item.Path];
                                pathInfo.ModifyTime = log.Time.ToLocalTime();
                            }
                            else
                            {
                                pathInfo = new SvnPathInfo();
                                pathInfo.FilePath = item.Path;
                                pathInfo.Author = log.Author;
                                pathInfo.ModifyTime = log.Time.ToLocalTime();
                                lstFiles[item.Path] = pathInfo;
                            }

                            if (log.LogMessage != null && log.LogMessage.Trim().Length > 0)
                            {
                                string[] messages = log.LogMessage.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (var msg in messages)
                                {
                                    if (string.IsNullOrWhiteSpace(msg))
                                        continue;
                                    pathInfo.Log.Append(msg + ";");
                                }
                            }
                        }
                    }
                }

                files = lstFiles.Values.ToArray();
            }

            return files;
        }

        void Authentication_UserNamePasswordHandlers(object sender, SvnUserNamePasswordEventArgs e)
        {
            e.UserName = "mscsdev";
            e.Password = "1";
            e.Save = true;
        }

        private bool ContainsExclude(string path)
        {
            List<string> lstExclude = new List<string> { ".sln", ".csproj", ".licx" };
            foreach (var ex in lstExclude)
            {
                if (path.EndsWith(ex))
                {
                    return true;
                }
            }

            return false;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var files = dvList.DataSource as IEnumerable<SvnPathInfo>;
                if (files == null)
                {
                    MessageBox.Show("请先查询出SVN日志");
                    return;
                }

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.DefaultExt = "xlsx";
                dialog.FileName = string.Format("SVN变更日志_{0}.xlsx", DateTime.Now.ToString("yyyy-MM-dd-HHmm"));
                dialog.Filter = "Excel文件(*.xlsx)|*.xlsx";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    ExcelExporter.Export(files, dialog.FileName);
                    MessageBox.Show("导出成功");
                    Process.Start("explorer.exe ", dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败：" + ex.ToString());
            }
        }
    }

    public class SvnPathInfo
    {
        public StringBuilder Log { get; set; }

        public string FilePath { get; set; }

        public string Author { get; set; }

        public DateTime ModifyTime { get; set; }

        public string Remark { get { return Log.ToString().TrimEnd(';').Trim(); } }

        public string ResolvePath { get { return FilePath.Replace("/trunk/", ""); } }

        public string Group
        {
            get
            {
                var lstSegMent = ResolvePath.Split('/');
                if (lstSegMent.Count() > 2)
                {
                    return lstSegMent[0] + '/' + lstSegMent[1];
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public SvnPathInfo()
        {
            Log = new StringBuilder();
            Author = "";
            FilePath = string.Empty;
        }
    }
}
