using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._5Singleton.More.DoubleCheckLocking
{
    class DoubleCheckLocking
    {
        private static volatile DoubleCheckLocking _instance;
        private static object _syncRoot = new object();

        public static DoubleCheckLocking Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                            _instance = new DoubleCheckLocking();
                    }
                }
                return _instance;
            }
        }
    }
}
