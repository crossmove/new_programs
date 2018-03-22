using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary1
{
    /*
     * Threading does only TimeSlicing or Context Switching between threads
     * TPL breaks into pieces and assing to free processor or which got less work so utilizaiton of the all the CPU will be atmost same
     * Threading has affinity with the processor, menas once a thread is assigned a processor core, the thread executes in the same core.
     * We can see the utilization of CPU using Task Parallel Library in Performance Monitor tool ( Windows Default)
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 1000000, x => Execute());
        }   

        static void Execute()
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x = x + "S";
            }
        }
    }
}
