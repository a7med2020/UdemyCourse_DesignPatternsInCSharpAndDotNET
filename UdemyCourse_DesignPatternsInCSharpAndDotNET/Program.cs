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
            SingletonExercise.Execute();
            Console.ReadKey();
        }
    }
}
