using System;
using System.Collections.Generic;
using static System.Console;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._8Composite.More.CompositePatternExample
{
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

    public class CompositeShape : Shape
    {
        private List<Shape> shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void RemoveShape(Shape shape)
        {
            shapes.Remove(shape);
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing composite shape:");
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }

    public class ChatGPTExample
    {
        public static void Execute()
        {
            var circle = new Circle();
            var rectangle = new Rectangle();

            var compositeShape = new CompositeShape();
            compositeShape.AddShape(circle);
            compositeShape.AddShape(rectangle);

            compositeShape.Draw();
        }
    }
   
}
