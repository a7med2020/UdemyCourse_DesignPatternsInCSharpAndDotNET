using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._5Singleton.More.StaticConstructor
{
    //https://stackoverflow.com/questions/5950418/double-check-locking-in-singleton-pattern
    //    Jon Skeet explains this in detail. //http://csharpindepth.com/Articles/General/Singleton.aspx

    //Locks are expensive.
    //If the object already exists, there's no point in taking out a lock.
    //Thus, you have a first check outside the lock.

    //However, even if the object didn't exist before you took the look, another thread may have created it between the if condition and the lock statement.
    //Therefore, you need to check again inside the lock.

    //However, the best way to write a singleton is to use a static constructor:
    public sealed class Singleton
    {
        private Singleton()
        {
        }

        public static Singleton Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton instance = new Singleton();
        }
    }
}
