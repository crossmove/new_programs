using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class FibonacciSeries
    {
        public static void Fib(int fibNum)
        {
            //Print 1st 10 fib numbers
            for (int i = 0; i < fibNum; i++)
            {
                FibonacciPrint(i);
            }
        }

        public static void FibonacciPrint(int num)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < num; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
            }
            Console.WriteLine("Fib "+ ++num + " = "+a);
        }
    }
}
