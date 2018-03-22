using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net4._0Features
{
    class TupleExample
    {
        public static void Method()
        {
            Tuple<int, string, bool, RandomClass> tuple = new Tuple<int, string, bool, RandomClass>(1, "Name", true , new RandomClass(){ id = 32 });

            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4.id);

            var tupleobj = Tuple.Create(1, "Princy", true);           
        }

        public class RandomClass
        {
          public  int id = 930;
        }
    }
}
