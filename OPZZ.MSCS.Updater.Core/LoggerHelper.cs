using log4net;
using System;
using System.IO;

namespace OPZZ.MSCS.Updater.Core
{
    public static class LoggerHelper
    {
        private static ILog logInfo = LogManager.GetLogger("logAll");
        private static ILog logError = LogManager.GetLogger("error");

        static LoggerHelper()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(AppContext.Log4NetFile));
        }

        public static void Info(string message)
        {
            logInfo.Info(message);
        }

        public static void Error(string message)
        {
            logError.Error(message);
        }

        public static void Error(Exception ex)
        {
            Error(ex.Message, ex);
        }

        public static void Error(string message, Exception ex)
        {
            logError.Error(message, ex);
        }
    }
}
