using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class ServerGroup
    {
        public ServerGroup()
        {
            this.ServerConfigs = new List<ServerConfig>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<ServerConfig> ServerConfigs { get; set; }

        public static IEnumerable<ServerGroup> GetList()
        {
            var groupList = SqlServerHelper.GetList<ServerGroup>("select * from MSCS_Server_Group");
            var configList = ServerConfig.GetList();
            foreach (var group in groupList)
            {
                group.ServerConfigs.AddRange(configList.Where(x => x.GroupId == group.Id));
            }

            return groupList;
        }

        public static int Insert(ServerGroup group)
        {
            string sql = "INSERT INTO MSCS_Server_Group(Name) Values(@Name)";
            return SqlServerHelper.Execute(sql, group);
        }
    }
}
