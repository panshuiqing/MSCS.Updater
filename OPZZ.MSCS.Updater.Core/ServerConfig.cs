using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class ServerConfig
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ClientRootPath { get; set; }

        public string ServerRootPath { get; set; }

        public string ServerAddress { get; set; }

        public int GroupId { get; set; }

        public static IEnumerable<ServerConfig> GetList()
        {
            return SqlServerHelper.GetList<ServerConfig>("select * from MSCS_Server_Config");
        }
    }
}
