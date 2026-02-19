using Serilog;
using System;

namespace LCPInfrastructure
{
    public class LCPLogUtils
    {
        private static bool isInitialized;

        /// <summary>
        /// Writes the log event with the Information level 
        /// </summary>
        /// <param name="aMessage"> message to be logged </param>
        /// <param name="aMemberName"></param>
        /// <param name="aSourceFilePath"></param>
        /// <param name="aSourceLineNumber"></param>
        public static void LogInformation(string aMessage,
            [System.Runtime.CompilerServices.CallerMemberName] string aMemberName = "",
            [System.Runtime.CompilerServices.CallerFilePath] string aSourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int aSourceLineNumber = 0)
        {
            if (!isInitialized)
            {
                //If not initialized , initialize the logger 
                Initialize();
            }
            Log.Information($"{aMessage},  Member Name :{aMemberName}, " +
                $"Source File :{aSourceFilePath}, Line Number : {aSourceLineNumber}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aMessage"></param>
        /// <param name="aMemberName"></param>
        /// <param name="aSourceFilePath"></param>
        /// <param name="aSourceLineNumber"></param>
        public static void Debug(string aMessage,
            [System.Runtime.CompilerServices.CallerMemberName] string aMemberName = "",
            [System.Runtime.CompilerServices.CallerFilePath] string aSourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int aSourceLineNumber = 0)
        {
            if (!isInitialized)
            {
                //If not initialized , initialize the logger 
                Initialize();
            }
            Log.Debug($"{aMessage},  Member Name :{aMemberName}, " +
                $"Source File :{aSourceFilePath}, Line Number : {aSourceLineNumber}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aMessage"></param>
        /// <param name="aMemberName"></param>
        /// <param name="aSourceFilePath"></param>
        /// <param name="aSourceLineNumber"></param>
        public static void Warning(string aMessage,
           [System.Runtime.CompilerServices.CallerMemberName] string aMemberName = "",
           [System.Runtime.CompilerServices.CallerFilePath] string aSourceFilePath = "",
           [System.Runtime.CompilerServices.CallerLineNumber] int aSourceLineNumber = 0)
        {
            if (!isInitialized)
            {
                //If not initialized , initialize the logger 
                Initialize();
            }
            Log.Warning($"{aMessage},  Member Name :{aMemberName}, " +
                $"Source File :{aSourceFilePath}, Line Number : {aSourceLineNumber}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aMessage"></param>
        /// <param name="aMemberName"></param>
        /// <param name="aSourceFilePath"></param>
        /// <param name="aSourceLineNumber"></param>
        public static void Error(string aMessage,
           [System.Runtime.CompilerServices.CallerMemberName] string aMemberName = "",
           [System.Runtime.CompilerServices.CallerFilePath] string aSourceFilePath = "",
           [System.Runtime.CompilerServices.CallerLineNumber] int aSourceLineNumber = 0)
        {
            if (!isInitialized)
            {
                //If not initialized , initialize the logger 
                Initialize();
            }
            Log.Error($"{aMessage},  Member Name :{aMemberName}, " +
                $"Source File :{aSourceFilePath}, Line Number : {aSourceLineNumber}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aException"></param>
        /// <param name="aClassName"></param>
        /// <param name="aMethodName"></param>
        /// <param name="aMessage"></param>
        public static void LogException(Exception aException,
            string aClassName, string aMethodName, string aMessage = "")
        {
            if (!isInitialized)
            {
                Initialize();
            }
            Log.Error(aException, $"{aMessage} Class Name :{aClassName}, Method Name :{aMethodName} ");
        }
        /// <summary>
        /// 
        /// </summary>
        private static void Initialize()
        {

            string MyDocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = MyDocumentPath + @"\LCP\logs\Log.txt";
            string logFilePath = path;
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day,
                rollOnFileSizeLimit: true, fileSizeLimitBytes: 10000)
                .CreateLogger();
            isInitialized = true;
        }
    }
}
