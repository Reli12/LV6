using ChaneOfDependenci.Logging;
using ChaneOfDependenci.Passwords;
using System;

namespace ChaneOfDependenci
{
    class Program
    {
        static void Main(string[] args)
        {
            RunLoggingDemo();
            RunPassWordDemo();
        }

        private static void RunPassWordDemo()
        {
            int minLenght = 0;
            PasswordValidator validator = new PasswordValidator(new StringLenghtCheck(minLenght));
            validator.Add(new StringDigitChecker());

            Console.WriteLine(validator.isGoodPassword("asdf"));
            //dz još dvije implementacije
        }

        private static void RunLoggingDemo()
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(
               MessageType.ERROR | MessageType.WARNING, 
               "logFile.txt"
               );
            logger.SetNextLogger(fileLogger);

            logger.Log("Log this!", MessageType.INFO);
            logger.Log("Such eror ! Much wow.", MessageType.ERROR);
        }
    }
}
