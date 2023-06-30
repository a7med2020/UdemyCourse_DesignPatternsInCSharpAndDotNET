using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._9Decorator.More.ShapeDecorator
{
    public interface Shape
    {
        void draw();
    }

    public class Rectangle : Shape
    {

        public void draw()
        {
            Write("Shape: Rectangle");
        }
    }

    public class Circle : Shape
    {
        public void draw()
        {
            Write("Shape: Circle");
        }
    }

    public abstract class ShapeDecorator : Shape
    {
        protected Shape decoratedShape;

        public ShapeDecorator(Shape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public void draw()
        {
            decoratedShape.draw();
        }
    }

    public class RedShapeDecorator : ShapeDecorator
    {

        public RedShapeDecorator(Shape decoratedShape) : base(decoratedShape)
        {
        }

        public void draw()
        {
            decoratedShape.draw();
            setRedBorder(decoratedShape);
        }

        private void setRedBorder(Shape decoratedShape)
        {
            Write("Border Color: Red");
        }
    }

    public class ShapeDecoratorDemo
    {
        public static void Execute()
        {

            Shape circle = new Circle();

            Shape redCircle = new RedShapeDecorator(new Circle());

            Shape redRectangle = new RedShapeDecorator(new Rectangle());
            Write("Circle with normal border");
            circle.draw();

            Write("\nCircle of red border");
            redCircle.draw();

            Write("\nRectangle of red border");
            redRectangle.draw();
        }
    }
}
