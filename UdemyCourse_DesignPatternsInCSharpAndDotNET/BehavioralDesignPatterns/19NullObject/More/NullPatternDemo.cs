using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.BehavioralDesignPatterns._19NullObject.More
{
    public abstract class AbstractCustomer
    {
        protected String name;
        public abstract bool isNil();
        public abstract String getName();
    }


    public class RealCustomer : AbstractCustomer
    {

        public RealCustomer(String name)
        {
            this.name = name;
        }

        public override String getName()
        {
            return name;
        }

        public override bool isNil()
        {
            return false;
        }
    }

    public class NullCustomer : AbstractCustomer
    {
        public override String getName()
        {
            return "Not Available in Customer Database";
        }

        public override bool isNil()
        {
            return true;
        }
    }

    public class CustomerFactory
    {
        public static String[] names = { "Rob", "Joe", "Julie" };
        public static AbstractCustomer getCustomer(String name)
        {

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(name))
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }

    public class NullPatternDemo
    {
        public static void main(String[] args)
        {
            AbstractCustomer customer1 = CustomerFactory.getCustomer("Rob");
            AbstractCustomer customer2 = CustomerFactory.getCustomer("Bob");
            AbstractCustomer customer3 = CustomerFactory.getCustomer("Julie");
            AbstractCustomer customer4 = CustomerFactory.getCustomer("Laura");

            WriteLine("Customers");
            WriteLine(customer1.getName());
            WriteLine(customer2.getName());
            WriteLine(customer3.getName());
            WriteLine(customer4.getName());
        }
    }
}
