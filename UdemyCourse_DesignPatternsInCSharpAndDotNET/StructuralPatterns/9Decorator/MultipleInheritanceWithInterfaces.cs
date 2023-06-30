using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._9Decorator.MultipleInheritanceWithInterfaces
{
    public class MultipleInheritanceWithInterfaces
    {
        public class Bird
        {
            public void Fly()
            {

            }
        }

        public class Lizard
        {
            public void Crawl()
            {

            }
        }

        public class Dragon // no multiple inheritance
        {
            private Bird bird;
            private Lizard lizard;

            public Dragon(Bird bird, Lizard lizard)
            {
                this.bird = bird ?? throw new ArgumentNullException(paramName: nameof(bird));
                this.lizard = lizard ?? throw new ArgumentNullException(paramName: nameof(lizard));
            }

            public void Crawl()
            {
                lizard.Crawl();
            }

            public void Fly()
            {
                bird.Fly();
            }
        }
    }
}
