using FluentFTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class FtpHelper
    {
        public FtpHelper(FtpConfig config)
        {
            this.FtpRootPath = config.RootPath;
            this.Client = CreateClient(config);
        }

        public string FtpRootPath { get; private set; }

        public FtpClient Client { get; private set; }

        private FtpClient CreateClient(FtpConfig config)
        {

            FtpClient client = new FtpClient(config.Host, config.Port, config.User, config.Password);
            client.ConnectTimeout = 30000;

            //https://github.com/robinrodricks/FluentFTP#trouble_closedhost
            client.SocketPollInterval = 1000;

            return client;
        }
    }
}
