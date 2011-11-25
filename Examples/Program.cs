namespace Examples
{
    using System;
    using Logger;

    /// <summary>
    /// This is the example program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This is the main example program method.
        /// </summary>
        public static void Main()
        {
            Program.HowToLogDifferentLevels();
            Program.HowToFilterLevels();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// This demonstrates how to log different types of levels.
        /// </summary>
        private static void HowToLogDifferentLevels()
        {
            Logger logger = new Logger();
            logger.Log("Different Levels Demo:", Logger.Level.NONE);

            logger.Log("This is a message with no level.", Logger.Level.NONE);
            logger.Log(
                "This is a debug message, which only is shown when the project is compiled in debug mode.",
                Logger.Level.DEBUG);
            logger.Log("This is a low level message.", Logger.Level.LOW);
            logger.Log("This is a medium level message.", Logger.Level.MEDIUM);
            logger.Log("This is a high level message.", Logger.Level.HIGH);
            logger.Log(
                "This is a message set to both low and high, demonstrating how the more severe level is chosen.",
                Logger.Level.LOW | Logger.Level.HIGH);

            logger.Log(string.Empty, Logger.Level.NONE);
        }

        /// <summary>
        /// This demonstrates how to use the PermittedLevels member to filter out different levels of logs.
        /// </summary>
        private static void HowToFilterLevels()
        {
            Logger logger = new Logger();
            logger.Log("Filter Levels Demo:", Logger.Level.NONE);

            logger.DefaultLevel = Logger.Level.MEDIUM;
            logger.PermittedLevels = Logger.Level.MEDIUM;
            logger.Log("This log is shown.");
            logger.PermittedLevels = Logger.Level.LOW;
            logger.Log("This log is not shown.");
            logger.PermittedLevels = Logger.Level.HIGH;
            logger.Log("This log is also not shown.");

            logger.PermittedLevels = Logger.Level.NONE;
            logger.Log(string.Empty, Logger.Level.NONE);
        }
    }
}
