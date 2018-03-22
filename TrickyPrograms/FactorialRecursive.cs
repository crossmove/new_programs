using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class FactorialRecursive
    {
        public static void factDriver(int num)
        {
            Console.WriteLine(Fact(num));
        }

        public static int Fact(int number)
        {
            if (number > 0)
            {
                return number * Fact(number - 1); 
            }
            else return 1;
        }

        public static void FactorialNormal(int num)
        {
            int factNum = 1;
            for (int i = 1; i <= num; i++)
            {
                factNum = factNum * i; 
            }
            Console.WriteLine(factNum);
        }
    }
}
