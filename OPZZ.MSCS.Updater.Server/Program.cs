using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            UpdaterService service = new UpdaterService();
            service.Start().Wait();
        }
    }
}
