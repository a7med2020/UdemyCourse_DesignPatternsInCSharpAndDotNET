using System;
using System.Collections.Generic;
using System.Text;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.Creational_Patterns._2Factories;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.Creational_Patterns._2Factories.FactoryExercise;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.Creational_Patterns.Builder;
using UdemyCourse_DesignPatternsInCSharpAndDotNET.TheSOLIDDesignPrinciples;

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
            FactoryExercise.Execute();
            Console.ReadKey();
        }
    }
}
