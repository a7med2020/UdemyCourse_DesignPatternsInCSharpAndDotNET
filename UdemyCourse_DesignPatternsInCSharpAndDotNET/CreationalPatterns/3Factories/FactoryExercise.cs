using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._3Factories.FactoryExercise
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PersonFactory
    {
        private int id = 0;

        public Person CreatePerson(string name)
        {
            return new Person { Id = id++, Name = name };
        }
    }

    public class FactoryExercise
    {
        public static void Execute()
        {
            var pf = new PersonFactory();

            var p1 = pf.CreatePerson("Chris");
            Console.WriteLine($"Person Id:{p1.Id}, Person Name:{p1.Name}");

            var p2 = pf.CreatePerson("Sarah");
            Console.WriteLine($"Person Id:{p2.Id}, Person Name:{p2.Name}");

        }
    }
}
