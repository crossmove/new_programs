using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Linq_Class
    {
        public static void Method()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            IEnumerable<int> resutl = list.Where(elem => elem > 2); //Consider this as for each loop functionality

            IEnumerable<int> resut2  = from elem in list
                                       where elem > 2
                                       select elem;

            foreach (var item in resut2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
