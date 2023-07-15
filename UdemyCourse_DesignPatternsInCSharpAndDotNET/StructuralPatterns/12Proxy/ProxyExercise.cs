using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._12Proxy.ProxyExercise
{
    public class Person
    {
        public int Age { get; set; }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }

    public class ResponsiblePerson
    {
        Person person = new Person();
        public ResponsiblePerson(Person person)
        {
            this.person = person;
        }

        public string Drink()
        {
            if(this.Age >= 18)
            return person.Drink();
            else
                return "too young";
        }

        public string Drive()
        {
            if (this.Age >= 16)
                return person.Drive();
            else
                return "too young";
             
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }

        public int Age { set
            {
                 this.person.Age = value ;
            }
            get
            {
                return this.person.Age;
            }
        }
    }
    public class ProxyExercise
    {
    }
}
