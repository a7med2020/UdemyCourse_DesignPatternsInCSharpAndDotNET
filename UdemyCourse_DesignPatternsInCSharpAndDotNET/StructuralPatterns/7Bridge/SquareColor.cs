using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._7Bridge
{
    using System;

    // Implementor Interface
    public interface IColor
    {
        void ApplyColor();
    }

    // Concrete Implementors
    public class RedColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Applying red color.");
        }
    }

    public class BlueColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Applying blue color.");
        }
    }

    // Abstraction
    public abstract class Shape
    {
        protected IColor color;

        public Shape(IColor color)
        {
            this.color = color;
        }

        public abstract void Draw();
    }

    // Refined Abstractions
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
            color.ApplyColor();
        }
    }

    public class Square : Shape
    {
        public Square(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
            color.ApplyColor();
        }
    }

    // Client Code
    class SquareColor
    {
        static void Execute()
        {
            // Create a red circle
            Shape redCircle = new Circle(new RedColor());
            redCircle.Draw();

            // Create a blue square
            Shape blueSquare = new Square(new BlueColor());
            blueSquare.Draw();
        }
    }
 
}
