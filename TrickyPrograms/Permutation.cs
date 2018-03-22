using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class PermutationProgram
    {
        static void Main(string[] args)
        {
            List<string> First = new List<string>() { "a1", "a2", "a3", "a4" };

            List<string> second = new List<string>() { "b1", "b2" };

            List<string> third = new List<string>() { "c1", "c2", "c3", "c4", "c5" };

            int i = 0, j = 0, k = 0;

            while (i < First.Count)
            {
                j = 0;
                k = 0;
                while (j < second.Count)
                {
                    k = 0;
                    while (k < third.Count)
                    {
                        Console.WriteLine(string.Format("{0} {1} {2}", First[i], second[j], third[k]));
                        k++;
                    }
                    j++;
                }
                i++;

                Console.WriteLine("---------------------");
            }
        }
    }
}
