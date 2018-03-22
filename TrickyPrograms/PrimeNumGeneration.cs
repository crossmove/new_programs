using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class PrimeNumGeneration
    {
        public static void PrimeNum(int primeNumberInput)
        {
            for (int i = 2; i <= primeNumberInput; i++)
            {
                bool flag = true;
                for (int divider = 2; divider <= (i/2); divider++)
                {
                    if(i!=divider && (i % divider)==0)
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag == true)
                Console.WriteLine(i);
            }
        }
    }
}
