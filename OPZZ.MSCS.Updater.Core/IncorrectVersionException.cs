using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class IncorrectVersionException : Exception
    {
        public IncorrectVersionException() : base()
        { }

        public IncorrectVersionException(string message) : base(message)
        { }
    }
}
