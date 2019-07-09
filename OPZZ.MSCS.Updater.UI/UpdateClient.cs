using DotNetty.Codecs;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.UI
{
    public class UpdateClient
    {
        public UpdateClient(UpdaterClientHandler handler)
        {
            this.ClientHandler = handler;
        }

        public UpdaterClientHandler ClientHandler { get; set; }
        IChannel bootstrapChannel;
        MultithreadEventLoopGroup group;

        public async Task Connect()
        {
            try
            {
                group = new MultithreadEventLoopGroup();
                var bootstrap = new Bootstrap();
                bootstrap
                    .Group(group)
                    .Channel<TcpSocketChannel>()
                    .Option(ChannelOption.TcpNodelay, true)
                    .Handler(new ActionChannelInitializer<ISocketChannel>(channel =>
                    {
                        IChannelPipeline pipeline = channel.Pipeline;

                        pipeline.AddLast(new DelimiterBasedFrameDecoder(8192, Delimiters.LineDelimiter()));
                        pipeline.AddLast(new StringEncoder(), new StringDecoder(), ClientHandler);
                    }));

                bootstrapChannel = await bootstrap.ConnectAsync(new IPEndPoint(ClientSettings.Host, ClientSettings.Port));
            }
            catch
            {
                group.ShutdownGracefullyAsync().Wait(1000);
            }
        }

        public async Task Send(string word)
        {
            await bootstrapChannel.WriteAndFlushAsync(word + "\r\n");
        }

        public async Task Stop()
        {
            try
            {
                await bootstrapChannel.CloseAsync();
            }
            finally
            {
                group.ShutdownGracefullyAsync().Wait(1000);
            }
        }
    }
}
