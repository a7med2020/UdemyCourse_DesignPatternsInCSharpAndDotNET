using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.BehavioralDesignPatterns._17Medaitor.ExerciseMyAnswer
{
    public class Participant
    {
        public int Value { get; set; }
        public Mediator mediator;

        public Participant(Mediator mediator)
        {
            this.mediator = mediator;
            mediator.Join(this);
        }

        public void Say(int n)
        {
            mediator.Broadcast(this, n);
        }
    }

    public class Mediator
    {
        private List<Participant> Participants = new List<Participant>();
   
        public void Join(Participant participant)
        {
            Participants.Add(participant);
        }
        public void Broadcast(Participant source, int n)
        {
            foreach (var p in Participants)
                if (p != source)
                    p.Value += n;
        }
    }

    public class ExerciseMyAnswer
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
