using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._11Flyweight.More
{
    //https://www.tutorialspoint.com/design_pattern/flyweight_pattern.htm
    public interface Shape
    {
        void draw();
    }

    public class Circle : Shape
    {
        private String color;
        private int x;
        private int y;
        private int radius;

        public Circle(String color)
        {
            this.color = color;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setRadius(int radius)
        {
            this.radius = radius;
        }


        public void draw()
        {
            WriteLine("Circle: Draw() [Color : " + color + ", x : " + x + ", y :" + y + ", radius :" + radius);
        }
    }

    public class ShapeFactory
    {

        // Uncomment the compiler directive line and
        // javac *.java will compile properly.
        // @SuppressWarnings("unchecked")
       // private static sealed HashMap circleMap = new HashMap();

        //Dictionary<string, string> Pairs = new Dictionary<string, string>();

        //public static Shape getCircle(String color)
        //{
        //    Circle circle = Pairs.;

        //    if (circle == null)
        //    {
        //        circle = new Circle(color);
        //        circleMap.put(color, circle);
        //        System.out.println("Creating circle of color : " + color);
        //    }
        //    return circle;
        //}
    }
}
