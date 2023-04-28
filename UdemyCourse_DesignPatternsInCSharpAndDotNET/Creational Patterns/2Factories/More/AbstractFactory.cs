using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.Creational_Patterns._2Factories.More.AbstractFactory
{
    public interface Shape
    {
        void draw();
    }

    public class RoundedRectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside RoundedRectangle::draw() method.");
        }
    }


    public class RoundedSquare : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside RoundedSquare::draw() method.");
        }
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

    public abstract class AbstractFactory
    {
       public abstract Shape getShape(String shapeType);
    }

    public class ShapeFactory : AbstractFactory
    {
        public override Shape getShape(String shapeType)
        {
            if (shapeType.Equals("RECTANGLE"))
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

    public class RoundedShapeFactory : AbstractFactory
    {
        public override Shape getShape(String shapeType)
        {
            if (shapeType.Equals("RECTANGLE"))
            {
                return new RoundedRectangle();
            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new RoundedSquare();
            }
            return null;
        }
    }


    public class FactoryProducer
    {
        public static AbstractFactory getFactory(bool rounded)
        {
            if (rounded)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }

    public class AbstractFactoryPatternDemo
    {
        public static void Execute()
        {
            //get shape factory
            AbstractFactory shapeFactory = FactoryProducer.getFactory(false);
            //get an object of Shape Rectangle
            Shape shape1 = shapeFactory.getShape("RECTANGLE");
            //call draw method of Shape Rectangle
            shape1.draw();
            //get an object of Shape Square 
            Shape shape2 = shapeFactory.getShape("SQUARE");
            //call draw method of Shape Square
            shape2.draw();
            //get shape factory
            AbstractFactory shapeFactory1 = FactoryProducer.getFactory(true);
            //get an object of Shape Rectangle
            Shape shape3 = shapeFactory1.getShape("RECTANGLE");
            //call draw method of Shape Rectangle
            shape3.draw();
            //get an object of Shape Square 
            Shape shape4 = shapeFactory1.getShape("SQUARE");
            //call draw method of Shape Square
            shape4.draw();

        }
    }
}
