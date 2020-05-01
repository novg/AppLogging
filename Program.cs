using System;
using NLog;

namespace AppLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            logger.Trace("trace message");
            logger.Debug("debug message");
            logger.Info("info message");
            logger.Warn("warn message");
            logger.Error("error message");
            logger.Fatal("fatal message");

            logger.Error(new DivideByZeroException(), "value was not calculate");
        }
    }
}
