using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._4Prototype
{
    public class Point
    {
        public int X, Y;
    }

    public class Line
    {
        public Point Start, End;

        public Line DeepCopy()
        {
            var newStart = new Point { X = Start.X, Y = Start.Y };
            var newEnd = new Point { X = End.X, Y = End.Y };
            return new Line { Start = newStart, End = newEnd };
        }
    }

    public class PrototypeExercise
    {
        public static void Execute()
        {
            var line1 = new Line
            {
                Start = new Point { X = 3, Y = 3 },
                End = new Point { X = 10, Y = 10 }
            };

            var line2 = line1.DeepCopy();
            line1.Start.X = line1.End.X = line1.Start.Y = line1.End.Y = 0;

            Console.WriteLine(line2.Start.X);
            Console.WriteLine(line2.Start.Y);
            Console.WriteLine(line2.End.X);
            Console.WriteLine(line2.End.Y);
        }
    }
}
