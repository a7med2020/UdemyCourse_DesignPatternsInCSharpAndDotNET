using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.Creational_Patterns._2Factories.More.FactoryPattern
{
    public interface Shape
    {
        void draw();
    }



    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }

    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }

    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }

    public class ShapeFactory
    {

        //use getShape method to get object of type shape 
        public Shape getShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }

            return null;
        }
    }


    public class FactoryPatternDemo
    {

        public static void Execute()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Circle and call its draw method.
            Shape shape1 = shapeFactory.getShape("CIRCLE");

            //call draw method of Circle
            shape1.draw();

            //get an object of Rectangle and call its draw method.
            Shape shape2 = shapeFactory.getShape("RECTANGLE");

            //call draw method of Rectangle
            shape2.draw();

            //get an object of Square and call its draw method.
            Shape shape3 = shapeFactory.getShape("SQUARE");

            //call draw method of square
            shape3.draw();
        }
    }
}
