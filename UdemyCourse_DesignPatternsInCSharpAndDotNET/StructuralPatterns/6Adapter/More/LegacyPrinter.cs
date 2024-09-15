using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._6Adapter.More
{
    public class LegacyPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Printing: " + text);
        }
    }

    public interface IPrinter
    {
        void PrintText(string text);
    }

    public class LegacyPrinterAdapter : IPrinter
    {
        private readonly LegacyPrinter _legacyPrinter;

        public LegacyPrinterAdapter(LegacyPrinter legacyPrinter)
        {
            _legacyPrinter = legacyPrinter;
        }

        public void PrintText(string text)
        {
            _legacyPrinter.Print(text);
        }
    }

    public class Program
    {
        public static void Main()
        {
            LegacyPrinter legacyPrinter = new LegacyPrinter();
            IPrinter printer = new LegacyPrinterAdapter(legacyPrinter);

            printer.PrintText("Hello, world!");
        }
    }
}
