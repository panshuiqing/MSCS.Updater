using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class UpdateHistory
    {
        public int ServerConfigId { get; set; }
        public string ServerConfigName { get; set; }
        public int FileCount { get; set; }
        public DateTime PublishAt { get; set; }

        public static int Insert(UpdateHistory history)
        {
            string sql = "INSERT INTO MSCS_Update_History(ServerConfigId, ServerConfigName, FileCount) Values(@ServerConfigId, @ServerConfigName, @FileCount)";
            return SqlServerHelper.Execute(sql, history);
        }

        public static IEnumerable<UpdateHistory> GetList(int serverConfigId)
        {
            return SqlServerHelper.GetList<UpdateHistory>($"select * from MSCS_Update_History where ServerConfigId = {serverConfigId} order by Id desc ");
        }

        public static UpdateHistory GetLatest(int serverConfigId)
        {
            return SqlServerHelper.Get<UpdateHistory>($"select top 1 * from MSCS_Update_History where ServerConfigId = {serverConfigId} order by Id desc ");
        }
    }
}
