using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class DebugRelease_IfElseProcessorDirective
    {
        public void method1()
        {   
#if DEBUG
            Console.WriteLine("Debug");
#else
            Console.WriteLine("Release");
#endif
        }
    }
}
/*
If you change to Release then it switches to else part.
 * */
