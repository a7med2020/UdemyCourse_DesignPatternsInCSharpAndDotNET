using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._7Bridge.BridgeExercise
{
    public interface IRenderer
    {
        string WhatToRenderAs { get; }
    }

    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs { get { return "lines"; } }
       
    }

    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs { get { return "pixels"; } }
       
    }

    public abstract class Shape
    {
        public IRenderer renderer { get; }

        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Drawing {Name} as {renderer.WhatToRenderAs}";
        }
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
            Name = "Triangle";
        }
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
            Name = "Square";
        }
    }

    public class BridgeExercise
    {
        public static void Execute()
        {
            Console.WriteLine(new Triangle(new RasterRenderer()).ToString());
        }
    }

    //public interface IRenderer
    //{
    //    string WhatToRenderAs { get; }
    //}

    //public abstract class Shape
    //{
    //    private IRenderer rendering;

    //    protected Shape(IRenderer rendering)
    //    {
    //        this.rendering = rendering;
    //    }

    //    public string Name { get; set; }

    //    public override string ToString()
    //    {
    //        return $"Drawing {Name} as {rendering.WhatToRenderAs}";
    //    }
    //}

    //public class Triangle : Shape
    //{
    //    public Triangle(IRenderer strategy) : base(strategy)
    //    {
    //        Name = "Triangle";
    //    }
    //}

    //public class Square : Shape
    //{
    //    public Square(IRenderer rendering) : base(rendering)
    //    {
    //        Name = "Square";
    //    }
    //}

    //public class RasterRenderer : IRenderer
    //{
    //    public string WhatToRenderAs
    //    {
    //        get { return "pixels"; }
    //    }
    //}

    //public class VectorRenderer : IRenderer
    //{
    //    public string WhatToRenderAs
    //    {
    //        get { return "lines"; }
    //    }
    //}
}