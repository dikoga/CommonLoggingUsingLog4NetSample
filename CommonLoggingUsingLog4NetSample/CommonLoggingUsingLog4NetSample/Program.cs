using Common.Logging;

namespace CommonLoggingUsingLog4NetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = LogManager.GetLogger(typeof(Program));
            log.Debug("test...");
        }
    }
}
