using DotNetty.Transport.Channels;
using OPZZ.MSCS.Updater.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.UI
{
    public class UpdaterClientEventArgs : EventArgs
    {
        public UpdaterClientEventArgs(string message)
        {
            this.Message = message;
        }
        public string Message { get; private set; }
    }

    public class UpdaterClientHandler : SimpleChannelInboundHandler<string>
    {
        public event EventHandler<UpdaterClientEventArgs> ReceiveMessage;

        protected override void ChannelRead0(IChannelHandlerContext contex, string msg)
        {
            if (msg == AppContext.SayBye)
            {
                contex.CloseAsync();
                RaiseReceiveMessage(new UpdaterClientEventArgs("断开与服务器的连接"));
                return;
            }
            else
            {
                RaiseReceiveMessage(new UpdaterClientEventArgs(msg));
            }            
        }

        public override void ExceptionCaught(IChannelHandlerContext contex, Exception e)
        {
            RaiseReceiveMessage(new UpdaterClientEventArgs($"发生异常：{e.StackTrace}"));
            contex.CloseAsync();
        }

        private void RaiseReceiveMessage(UpdaterClientEventArgs args)
        {
            var handler = ReceiveMessage;
            if (handler != null)
            {
                handler(this, args);
            }
        }
    }
}
