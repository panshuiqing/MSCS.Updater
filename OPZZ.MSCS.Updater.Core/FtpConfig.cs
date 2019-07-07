using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class FtpConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string RootPath { get; set; }

        public static FtpConfig FromConfiguration()
        {
            FtpConfig config = new FtpConfig();
            config.RootPath = ConfigurationManager.AppSettings["FTPRootPath"];
            config.Host = ConfigurationManager.AppSettings["FTPHost"];
            config.Port = int.Parse(ConfigurationManager.AppSettings["FTPPort"]);
            config.User = ConfigurationManager.AppSettings["FTPUser"];
            config.Password = ConfigurationManager.AppSettings["FTPPwd"];
            return config;
        }
    }
}
