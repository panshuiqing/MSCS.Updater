using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using OPZZ.MSCS.Updater.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Server
{
    public class UpdaterServerHandler : SimpleChannelInboundHandler<string>
    {
        public override void ChannelActive(IChannelHandlerContext context)
        {
            WriteMessage(context, "服务器已连接....");
        }

        protected override void ChannelRead0(IChannelHandlerContext contex, string msg)
        {
            bool close = false;
            if (string.Equals(AppContext.SayBye, msg, StringComparison.OrdinalIgnoreCase))
            {
                close = true;
            }
            else
            {
                try
                {
                    var data = JsonHelper.FromJson<UpdateData>(msg);
                    WriteMessage(contex, "1.1 -- 开始从FTP下载客户端文件....");
                    if (!DownloadFile(contex, data))
                    {
                        WriteMessage(contex, AppContext.SayBye);
                        return;
                    }
                    WriteMessage(contex, "1.2 -- 文件下载完成....");
                    WriteMessage(contex, "2.1 -- 开始更新UpdateList.xml....");

                    if (!HandleUpdateListFile(contex, data))
                    {
                        WriteMessage(contex, AppContext.SayBye);
                        return;
                    }

                    WriteMessage(contex, "2.2 -- UpdateList.xml更新完成....");
                    WriteMessage(contex, "3.升级完成....");
                    WriteMessage(contex, AppContext.SayBye);
                }
                catch (Exception ex)
                {
                    WriteMessage(contex, $"服务器端异常: {ex.Message}");
                    WriteMessage(contex, AppContext.SayBye);
                }                
            }

            if (close)
            {
                contex.CloseAsync();
            }
        }

        public override void ChannelReadComplete(IChannelHandlerContext contex)
        {
            contex.Flush();
        }

        public override void ExceptionCaught(IChannelHandlerContext contex, Exception e)
        {
            Console.WriteLine("{0}", e.StackTrace);
            LoggerHelper.Error("客户端连接异常", e);
            contex.CloseAsync();
        }

        public override bool IsSharable => true;

        private bool DownloadFile(IChannelHandlerContext context, UpdateData data)
        {
            var ftpHelper = new FtpHelper(FtpConfig.FromConfiguration());
            foreach (var file in data.Files)
            {
                var localPath = Path.Combine(data.Config.ServerRootPath, file.RelativePath);
                try
                {
                    ftpHelper.Client.DownloadFile(localPath, file.FtpPath, FluentFTP.FtpLocalExists.Overwrite);
                    WriteMessage(context, $"  文件{file.RelativePath}已下载..");
                }
                catch (Exception ex)
                {
                    WriteMessage(context, $"  文件{file.RelativePath}下载失败：{ex.Message}");
                    return false;
                }                
            }

            return true;
        }

        private bool HandleUpdateListFile(IChannelHandlerContext context, UpdateData data)
        {
            try
            {
                //1.读取更新
                var fileName = Path.Combine(data.Config.ServerRootPath, "UpdateList.xml");
                var info = UpdateListReader.Read(fileName);
                info.MergeUpdateFiles(data.Files);

                //2.保存
                UpdateListWriter.Write(fileName, info);
                WriteMessage(context, $"  程序的版本已经更新为：{info.Application.Version.ToString()}");
            }
            catch (Exception ex)
            {
                WriteMessage(context, $"  更新UpdateList.xml失败：{ex.Message}");
                return false;
            }
            
            return true;
        }

        private void WriteMessage(IChannelHandlerContext context, string message)
        {
            context.WriteAndFlushAsync(message +  AppContext.LineDelimiter);
        }
    }
}
