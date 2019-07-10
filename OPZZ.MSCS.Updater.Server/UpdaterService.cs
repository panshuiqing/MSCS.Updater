
using DotNetty.Codecs;
using DotNetty.Handlers.Logging;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using OPZZ.MSCS.Updater.Core;
using System;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Server
{
    public class UpdaterService
    {
        IEventLoopGroup bossGroup;
        IEventLoopGroup workerGroup;
        StringEncoder STRING_ENCODER = new StringEncoder();
        StringDecoder STRING_DECODER = new StringDecoder();
        IChannel bootstrapChannel;

        public async void Start()
        {
            bossGroup = new MultithreadEventLoopGroup(1);
            workerGroup = new MultithreadEventLoopGroup();
            
            try
            {
                var bootstrap = new ServerBootstrap();
                bootstrap
                    .Group(bossGroup, workerGroup)
                    .Channel<TcpServerSocketChannel>()
                    .Option(ChannelOption.SoBacklog, 100)
                    .Handler(new LoggingHandler(LogLevel.INFO))
                    .ChildHandler(new ActionChannelInitializer<ISocketChannel>(channel =>
                    {
                        IChannelPipeline pipeline = channel.Pipeline;

                        pipeline.AddLast(new DelimiterBasedFrameDecoder(8192, Delimiters.LineDelimiter()));
                        pipeline.AddLast(STRING_ENCODER, STRING_DECODER, new UpdaterServerHandler());
                    }));

                bootstrapChannel = await bootstrap.BindAsync(9527);
                Console.WriteLine("服务已启动...");
                LoggerHelper.Info("服务已启动...");
            }
            catch(Exception ex)
            {
                Console.WriteLine("服务启动异常：{0}", ex.StackTrace);
                LoggerHelper.Error("服务启动异常", ex);
            }
        }

        public async void Stop()
        {
            try
            {
                await bootstrapChannel.CloseAsync();
                await Task.WhenAll(
                    bossGroup.ShutdownGracefullyAsync(TimeSpan.FromMilliseconds(100), TimeSpan.FromSeconds(1)),
                    workerGroup.ShutdownGracefullyAsync(TimeSpan.FromMilliseconds(100), TimeSpan.FromSeconds(1)));
                Console.WriteLine("服务已停止...");
                LoggerHelper.Info("服务已停止...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("服务停止异常：{0}", ex.StackTrace);
                LoggerHelper.Error("服务停止异常", ex);
            }
        }
    }
}
