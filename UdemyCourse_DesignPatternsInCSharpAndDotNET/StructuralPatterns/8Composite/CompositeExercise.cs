using System.Collections;
using System.Collections.Generic;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._8Composite
{
    public interface IValueContainer : IEnumerable<int>
    {

    }

    public class SingleValue : IValueContainer
    {
        public int Value;

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }

    public class ManyValues : List<int>, IValueContainer
    {

    }

    public static class ExtensionMethods
    {
        public static int Sum(this List<IValueContainer> containers)
        {
            int result = 0;
            foreach (var c in containers)
                foreach (var i in c)
                    result += i;
            return result;
        }
    }
}


 