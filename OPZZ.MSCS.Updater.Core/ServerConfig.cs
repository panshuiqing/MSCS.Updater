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

        public static int Insert(ServerConfig config)
        {
            string sql = "INSERT INTO MSCS_Server_Config(Name, ClientRootPath, ServerAddress, ServerRootPath, GroupId) Values(@Name, @ClientRootPath, @ServerAddress, @ServerRootPath, @GroupId)";
            return SqlServerHelper.Execute(sql, config);
        }

        public static int Update(ServerConfig config)
        {
            string sql = "Update MSCS_Server_Config Set Name = @Name, ClientRootPath=@ClientRootPath, ServerAddress=@ServerAddress, ServerRootPath=@ServerRootPath Where Id = @Id";
            return SqlServerHelper.Execute(sql, config);
        }

        public static int Delete(int id)
        {
            string sql = "Delete MSCS_Server_Config Where Id = @Id";
            return SqlServerHelper.Execute(sql, new ServerConfig { Id = id });
        }
    }
}
