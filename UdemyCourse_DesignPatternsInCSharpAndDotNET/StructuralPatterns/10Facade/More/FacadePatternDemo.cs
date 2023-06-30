using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._10Facade.More.FacadeExercise
{

    public interface Shape
    {
        void draw();
    }


    public class Rectangle : Shape
    {


        public void draw()
        {
            Write("Rectangle::draw()");
        }
    }


    public class Square : Shape
    {

        public void draw()
        {
            Write("Square::draw()");
        }
    }


    public class Circle : Shape
    {

        public void draw()
        {
            Write("Circle::draw()");
        }
    }


    public class ShapeMaker
    {
        private Shape circle;
        private Shape rectangle;
        private Shape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void drawCircle()
        {
            circle.draw();
        }
        public void drawRectangle()
        {
            rectangle.draw();
        }
        public void drawSquare()
        {
            square.draw();
        }
    }

    public class FacadePatternDemo
    {
        public static void Execute()
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();
        }
    }


}
