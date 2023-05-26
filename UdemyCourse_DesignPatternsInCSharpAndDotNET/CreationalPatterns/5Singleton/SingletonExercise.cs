using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._5Singleton.SingletonExercise
{
        public class SingletonTester
        {
            public static bool IsSingleton(Func<object> func)
            {
                var obj1 = func();
                var obj2 = func();
                return ReferenceEquals(obj1, obj2);
            }
        }

    public class SingletonExercise
    {
        public static void Execute()
        {
            var obj = new object();
           Console.WriteLine(SingletonTester.IsSingleton(() => obj));
            Console.WriteLine(SingletonTester.IsSingleton(() => new object()));
        }
    }

    //[TestFixture]
    //public class FirstTestSuite
    //{
    //    [Test]
    //    public void Test()
    //    {
    //        var obj = new object();
    //        Assert.IsTrue(SingletonTester.IsSingleton(() => obj));
    //        Assert.IsFalse(SingletonTester.IsSingleton(() => new object()));
    //    }
    //}


}
