﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.BehavioralDesignPatterns._13ChainOfResponsibility.More
{
    public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int level;

        //next element in chain or responsibility
        protected AbstractLogger nextLogger;

        public void setNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void logMessage(int level, String message)
        {
            if (this.level <= level)
            {
                write(message);
            }
            if (nextLogger != null)
            {
                nextLogger.logMessage(level, message);
            }
        }

        abstract protected void write(String message);
    }

    public class ConsoleLogger : AbstractLogger
    {

        public ConsoleLogger(int level)
        {
            this.level = level;
        }

        protected override void write(String message)
        {
            WriteLine("Standard Console::Logger: " + message);
        }
    }

    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            this.level = level;
        }

        protected override void write(String message)
        {
            WriteLine("Error Console::Logger: " + message);
        }
    }

    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }

        protected override void write(String message)
        {
            WriteLine("File::Logger: " + message);
        }
    }

    public class ChainPatternDemo
    {

        private static AbstractLogger getChainOfLoggers()
        {

            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.setNextLogger(fileLogger);
            fileLogger.setNextLogger(consoleLogger);

            return errorLogger;
        }

        public static void Execute()
        {
            AbstractLogger loggerChain = getChainOfLoggers();

            loggerChain.logMessage(AbstractLogger.INFO,
               "This is an information.");

            loggerChain.logMessage(AbstractLogger.DEBUG,
               "This is an debug level information.");

            loggerChain.logMessage(AbstractLogger.ERROR,
               "This is an error information.");
        }
    }
}
