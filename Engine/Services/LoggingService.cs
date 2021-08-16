using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Services
{
    public static class LoggingService
    {
        private const string LOG_FILE_DIRECTORY = "Logs";

        static LoggingService()
        {
            string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LOG_FILE_DIRECTORY);

            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
        }

        public static void Log(Exception exception, bool isInnerException = false)
        {
            using (StreamWriter sw = new StreamWriter(LogFileName(), true))
            {
                sw.WriteLine(isInnerException ? "INNER EXCEPTION" : $"EXCEPTION: {DateTime.Now}");
                sw.WriteLine(new string(isInnerException ? '-' : '=', 40));
                sw.WriteLine($"{exception.Message}");
                sw.WriteLine($"{exception.StackTrace}");

                sw.WriteLine();
            }

            if (exception.InnerException != null)
            {
                Log(exception.InnerException, true);
            }
        }

        private static string LogFileName()
        {
            // This will create a separate log file for each day 
            // But we are not hoping for many of them
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LOG_FILE_DIRECTORY,
                $"SOSCSRPGG_{DateTime.Now:yyyyMMdd}.log");
        }
    }
}
