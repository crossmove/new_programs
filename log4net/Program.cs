/* 
 * reference: https://www.codeproject.com/Tips/1107824/Perfect-Log-Net-with-Csharp
 * 1. Install Log4net from Nuget Packet manager
 * 2. add [assembly: log4net.Config.XmlConfigurator(Watch = true)] after [assembly: AssemblyCulture("")] in AssemblyInfo.cs file
 * 3. In App.config add <configSections> and <log4net> sections
 * 4. The tag <file value="D:\MyTestAppender.log" /> in <log4net> defines the log file location.
 * 5. And Create a object Log as shown below 
 */
namespace log4net
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            string name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            Log.Fatal("Start log FATAL...");
            Log.Error("Start log Error...");
            Log.Warn("Start log Warn...");
            Log.Info("Start log Info...");
            Log.Debug("Start log Debug...");
        }
    }
}
/*output
 2018-03-04 21:43:15,512 FATAL [1] log4net.Program.Main - Start log FATAL...
2018-03-04 21:43:15,551 ERROR [1] log4net.Program.Main - Start log Error...
2018-03-04 21:43:15,552 WARN [1] log4net.Program.Main - Start log Warn...
2018-03-04 21:43:15,552 INFO [1] log4net.Program.Main - Start log Info...
2018-03-04 21:43:15,552 DEBUG [1] log4net.Program.Main - Start log Debug...
*/
 
