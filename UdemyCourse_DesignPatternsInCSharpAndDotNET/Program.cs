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
            ICloneableIsBad.Execute();
            CopyConstructors.Execute();
            Console.ReadKey();
        }
    }
}
