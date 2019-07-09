using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.UI
{
    class ClientSettings
    {
        public static IPAddress Host => IPAddress.Parse(ConfigurationManager.AppSettings["host"]);

        public static int Port => int.Parse(ConfigurationManager.AppSettings["port"]);
    }
}
