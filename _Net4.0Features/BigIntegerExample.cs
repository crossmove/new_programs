using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


//Import System.Numerics dll

namespace test
{
    class BigIntegerExample
    {
        public static void Example()
        {  
            //double val1 = Math.Pow(2, 31);
            //Console.WriteLine(val1);

            Int32 max = Int32.MaxValue;
            Int32 min = Int32.MinValue;
            Console.WriteLine(max);
            Console.WriteLine(min - 1);

            var myBigInteger = BigInteger.Parse("123456789123456789123456789");

            for (int i = 1; i < 10; i++)
            {
                myBigInteger *= myBigInteger;  //integer has by passed its limit, useful when decalring large value
            }
            Console.WriteLine(myBigInteger);
        }
    }
}
