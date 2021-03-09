using log4net;
using System;

namespace com.example.common
{
    public class LogHelper
    {
        public static void Debug(string message)
        {
            WriteLog(LogLevelEnum.Debug, message);
        }

        public static void Info(string message)
        {
            WriteLog(LogLevelEnum.Info, message);
        }

        public static void Warn(string message)
        {
            WriteLog(LogLevelEnum.Warn, message);
        }

        public static void Error(string message, Exception e)
        {
            WriteLog(LogLevelEnum.Error, message, e);
        }

        private static void WriteLog(LogLevelEnum logLevel, string message, Exception e = null)
        {
            switch (logLevel)
            {
                case LogLevelEnum.Debug:
                    LogManager.GetLogger("logDebug").Debug(message);
                    break;
                case LogLevelEnum.Info:
                    LogManager.GetLogger("logInfo").Info(message);
                    break;
                case LogLevelEnum.Warn:
                    LogManager.GetLogger("logWarn").Warn(message);
                    break;
                case LogLevelEnum.Error:
                    LogManager.GetLogger("logError").Error(message, e);
                    break;
            }
        }
    }
}
