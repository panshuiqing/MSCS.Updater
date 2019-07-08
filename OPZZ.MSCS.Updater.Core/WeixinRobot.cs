using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace OPZZ.MSCS.Updater.Core
{
    public class WeixinRobot
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public DateTime CreatedAt { get; set; }

        public static WeixinRobot Get(int id)
        {
            return SqlServerHelper.Get<WeixinRobot>($"select * from MSCS_Weixin_Robot where Id = {id}");
        }

        public static IEnumerable<WeixinRobot> GetList()
        {
            return SqlServerHelper.GetList<WeixinRobot>("select * from MSCS_Weixin_Robot");         
        }

        public static int Insert(WeixinRobot robot)
        {
            string sql = "INSERT INTO MSCS_Weixin_Robot(Name, Url) Values(@Name, @Url)";
            return SqlServerHelper.Execute(sql, robot);
        }

        public static int Delete(int id)
        {
            string sql = "Delete From MSCS_Weixin_Robot where Id = @Id";
            return SqlServerHelper.Execute(sql, new { Id = id });
        }
    }
}
