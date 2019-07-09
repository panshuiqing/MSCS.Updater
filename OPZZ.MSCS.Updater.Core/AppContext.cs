using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class AppContext
    {
        public static readonly string RootPath = GetRootPath();
        public static readonly string AppConString = ConfigurationManager.ConnectionStrings["AppConn"]?.ConnectionString;
        public static readonly string FilterList = ConfigurationManager.AppSettings["FilterList"] ?? ".pdb";
        public static readonly string Log4NetFile = Path.Combine(RootPath, "config", "log4net.config");
        public static readonly string SayBye = "bye";
        public static readonly string LineDelimiter = "\r\n";

        private static string GetRootPath()
        {
            string location = Assembly.GetExecutingAssembly().Location;
            string dir = new FileInfo(location).DirectoryName;
            return dir;
        }
    }
}
