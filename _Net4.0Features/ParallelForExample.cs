using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    //Foreach loop runs upon a single thread and processing takes place sequentially one by one.

    //Parallel.ForEach loop runs upon multiple threads and processing takes place in a  parallel way. 
    class ParallelForExample
    {
        static void Entry()
        {
            int[] numberArray = { 1, 2, 4, 5, 6, 8, 11, 22, 33, 11, 6, 7, 12, 44, 55, 66, 77, 88, 12, 90, 78, 100,88,00,88,67,88,67,45,88,99,34,78 };
            NormalExecution(numberArray);
            Console.WriteLine("\r\n\r\n");
            ParallelExecution(numberArray);
        }
       
        static void NormalExecution(int[] numberArray)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Parallel.ForEach(numberArray, (number) => { Console.WriteLine(number); Thread.Sleep(100); });
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            
        }

        static void ParallelExecution(int[] numberArray)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
                Thread.Sleep(100);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
