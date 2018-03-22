using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class ExceptIntersect
    {
        //HashSet does not include Duplicate, its removes automatically when we try to add 
        //HashSet is strongly typed
        static HashSet<string> set1 = new HashSet<string> { "mys", "mys", "delhi" };
        static HashSet<string> set2 = new HashSet<string> { "mys" };

        public static void PrintSet1()
        {
            Console.WriteLine("\r\n" + "--Print Set1--");
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
            /*
             mys
             delhi
            */
        }

        public static void Except()
        {
            var except = set1.Except(set2);
            Console.WriteLine("\r\n"+ "--except--");
            Print(except);
        }

        public static void Intersect()
        {
            var intesect = set1.Intersect(set2);
            Console.WriteLine("\r\n" + "--Intersect--");
            Print(intesect);
        }

        public static void Union()
        {
            var union = set1.Union(set2);
            Console.WriteLine("\r\n" + "--Union--");
            Print(union);
        }

        public static void Print(IEnumerable set)
        {
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
