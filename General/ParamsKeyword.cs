using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class ParamsKeyword
    {
        public static void Driver()
        {
            Sum(1, 2, 3, 4, 5);
        }

        public static void Sum(params int[] list)
        {
            int total = 0; 
            foreach (var item in list)
            {
                total = total + item;
            }
            Console.WriteLine(total);
        }
        // output: 15
    }
}
