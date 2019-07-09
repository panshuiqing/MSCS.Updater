using OPZZ.MSCS.Updater.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace OPZZ.MSCS.Updater.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<UpdaterService>(s =>
                {
                    s.ConstructUsing(name => new UpdaterService());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());

                });

                x.RunAsLocalSystem();

                x.SetServiceName("MSCS升级程序服务端");
                x.SetDisplayName("MSCS升级程序服务端");
                x.SetDescription("MSCS升级程序服务端");

            });
        }
    }
}
