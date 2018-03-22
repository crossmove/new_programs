using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    static class NullCoalescingOperator
    {
        public static void Method()
        {
            string one = "";
            string two = null;
            string three = null;
            string four = "pradeep";

            string result1 = one ?? two ?? three ?? four; Console.WriteLine(result1);//op: Empty String
            string result2 = two ?? three ?? four; Console.WriteLine(result2); //op: pradeep
        }
    }
}
