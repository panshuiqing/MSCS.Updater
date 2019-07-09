using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class UpdateData
    {
        public ServerConfig Config { get; set; }

        public UpdateFileInfo[] Files { get; set; }
    }
}
