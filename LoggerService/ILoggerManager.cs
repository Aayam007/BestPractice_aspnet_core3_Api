using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerService
{
   public interface ILoggerManager
    {
        void LogInfo(string Message);
        void LogWarn(string Message);
        void LogDebug(string Message);
        void LogError(string Message);
    }
}
