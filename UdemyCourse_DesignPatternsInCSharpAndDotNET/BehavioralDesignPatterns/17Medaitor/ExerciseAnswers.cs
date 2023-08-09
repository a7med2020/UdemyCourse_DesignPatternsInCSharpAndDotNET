using System;
using NUnit.Framework;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.BehavioralDesignPatterns._17Medaitor.ExerciseAnswers
{
    namespace Coding.Exercise
    {
        public class Participant
        {
            private readonly Mediator mediator;
            public int Value { get; set; }

            public Participant(Mediator mediator)
            {
                this.mediator = mediator;
                mediator.Alert += Mediator_Alert;
            }

            private void Mediator_Alert(object sender, int e)
            {
                if (sender != this)
                    Value += e;
            }

            public void Say(int n)
            {
                mediator.Broadcast(this, n);
            }
        }

        public class Mediator
        {
            public void Broadcast(object sender, int n)
            {
                Alert?.Invoke(sender, n);
            }

            public event EventHandler<int> Alert;
        }

        public class ExerciseAnswers
        {
            public static void Execute()
            {
                Mediator mediator = new Mediator();
                Participant p1 = new Participant(mediator);
                Participant p2 = new Participant(mediator);
                Participant p3 = new Participant(mediator);

                //mediator.Join(p1);
                //mediator.Join(p2);

                p1.Say(3);
                p2.Say(2);
                p2.Say(7);
                p3.Say(5);
                p1.Say(1);
                p2.Say(6);
                p3.Say(9);

                Console.WriteLine("P1:" + p1.Value);
                Console.WriteLine("P2:" + p2.Value);
                Console.WriteLine("P3:" + p3.Value);
            }
        }
    }

    namespace Coding.Exercise.Tests
    {
        [TestFixture]
        public class TestSuite
        {
            [Test]
            public void Test()
            {
                Mediator mediator = new Mediator();
                var p1 = new Participant(mediator);
                var p2 = new Participant(mediator);

                Assert.That(p1.Value, Is.EqualTo(0));
                Assert.That(p2.Value, Is.EqualTo(0));

                p1.Say(2);

                Assert.That(p1.Value, Is.EqualTo(0));
                Assert.That(p2.Value, Is.EqualTo(2));

                p2.Say(4);

                Assert.That(p1.Value, Is.EqualTo(4));
                Assert.That(p2.Value, Is.EqualTo(2));
            }
        }

    }

}