using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Server
{
    public class UpdaterServerHandler : SimpleChannelInboundHandler<string>
    {
        public override void ChannelActive(IChannelHandlerContext contex)
        {
            contex.WriteAsync($"服务器已经连接: {DateTime.Now}");
        }

        protected override void ChannelRead0(IChannelHandlerContext contex, string msg)
        {
            bool close = false;
            if (string.Equals("bye", msg, StringComparison.OrdinalIgnoreCase))
            {
                close = true;
            }
            else
            {
                Console.WriteLine(msg);
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

            contex.CloseAsync();
        }

        public override bool IsSharable => true;
    }
}
