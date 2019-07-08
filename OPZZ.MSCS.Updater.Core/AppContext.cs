using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class AppContext
    {
        public static readonly string AppConString = ConfigurationManager.ConnectionStrings["AppConn"]?.ConnectionString;
    }
}
