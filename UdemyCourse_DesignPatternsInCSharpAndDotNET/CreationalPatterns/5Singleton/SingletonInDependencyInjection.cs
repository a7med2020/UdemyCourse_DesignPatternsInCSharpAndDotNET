using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._5Singleton.SingletonInDependencyInjection
{
    public class Foo
    {
        public EventBroker Broker;

        public Foo(EventBroker broker)
        {
            Broker = broker ?? throw new ArgumentNullException(paramName: nameof(broker));
        }
    }

    public class EventBroker
    {

    }

    // socially acceptable 
    public class SingletonInDependencyInjection
    {
        public static void Execute()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EventBroker>().SingleInstance();
            builder.RegisterType<Foo>();

            using (var c = builder.Build())
            {
                var foo1 = c.Resolve<Foo>();
                var foo2 = c.Resolve<Foo>();

                Console.WriteLine(ReferenceEquals(foo1, foo2));
                Console.WriteLine(ReferenceEquals(foo1.Broker, foo2.Broker));
            }

        }
    }

    
}
