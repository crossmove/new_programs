using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace General
{
    //Notes
    // 1. Check this program is in Release mode
    // 2. Check the output with and without Volatile keyword.
    //Inference: if you mention volatile the variable always reads value from main memory which always has updated value
    // if you dont use volatile, the newly created thread updates only local memory and the main thread reads from main memory.

    class VolatileClass
    {
        private volatile bool _loop = true;   //Check output with and without volatile keyword
        public static void Method()
        {
            VolatileClass test1 = new VolatileClass();
            Thread obj = new Thread(SomeThread);
            obj.Start(test1);

            Thread.Sleep(20);

            test1._loop = false;
            Console.WriteLine("Step 2: Value is set to false");

        }

        private static void SomeThread(object o1)
        {
            VolatileClass o = (VolatileClass)o1;
            Console.WriteLine("Step 1: Entered the loop");
            while(o._loop)
            {

            }
            Console.WriteLine("Step 3: Exited the loop");

        }
    }
}
