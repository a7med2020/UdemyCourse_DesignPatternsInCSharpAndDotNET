using System;
using System.Collections.Generic;
using System.Text;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._3Factories;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._3Factories.FactoryExercise;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._2Builder;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.TheSOLIDDesignPrinciples;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._4Prototype;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._4Prototype.ICloneableIsBad;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._4Prototype.CopyConstructors;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._5Singleton.SingletonImplementation;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._5Singleton;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._5Singleton.Monostate;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._5Singleton.PerThread;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._5Singleton.SingletonInDependencyInjection;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._5Singleton.SingletonExercise;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._6Adapter.Vector_RasterDemo;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._6Adapter.AdapterCaching;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._6Adapter.GenericValueAdapter;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._6Adapter.AdapterInDependencyInjections;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._7Bridge.BridgeExercise;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._8Composite.GeometricShapes;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._8Composite.More.CompositePatternExample;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._9Decorator.CustomStringBuilder;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._9Decorator.AdapterDecorator;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._9Decorator.DynamicDecoratorComposition;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = new StringBuilder();
            //Console.WriteLine(a);
            //OpenClosedPrinciple.Execute();
            //LiskovSubstitutionPrinciple.Execute();
            //DependencyInversionPrinciple.Execute();
            //HtmlElementBuilderDemo.Execute();
            //BuilderInheritance.Execute();
            //BuilderExercise.Execute();
            //BulkReplacement.Execute();
            //FactoryExercise.Execute();
            //ICloneableIsBad.Execute();
            //CopyConstructors.Execute();
            //SingletonImplementation.Execute();
            //SingletonInDependencyInjection.Execute();
            //Monostate.Execute();
            //PerThread.Execute();
            //SingletonExercise.Execute();
            //Vector_RasterDemo.Execute();
            //AdapterCaching.Execute();
            //GenericValueAdapter.Execute();
            //AdapterInDependencyInjection.Execute();
            //BridgeExercise.Execute();
            //GeometricShapes.Execute();
            //ChatGPTExample.Execute();
            //CustomStringBuilder.Execute();
            //AdapterDecorator.Execute();
            DynamicDecoratorComposition.Execute();
            Console.ReadKey();
        }
    }
}
