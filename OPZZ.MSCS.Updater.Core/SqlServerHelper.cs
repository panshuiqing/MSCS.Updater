using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class SqlServerHelper
    {
        public static IEnumerable<T> GetList<T>(string sql)
        {
            using (var conn = new SqlConnection(AppContext.AppConString))
            {
                return conn.Query<T>(sql);
            }
        }

        public static T Get<T>(string sql)
        {
            var list = GetList<T>(sql).ToList();
            if (list == null || list.Count == 0)
            {
                return default(T);
            }
            else
            {
                return list[0];
            }
        }

        public static int Execute(string sql, object entity)
        {
            using (var conn = new SqlConnection(AppContext.AppConString))
            {
                return conn.Execute(sql, entity);
            }
        }
    }
}
