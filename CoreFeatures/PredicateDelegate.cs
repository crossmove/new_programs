using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFeatures
{
    class PredicateDelegate
    {
        public static void Method()
        {
            
            //Three different implementation of Predicate
            //1.Normal
            //2.Anonymous function
            //3.Lambda Expression

            Predicate<int> isEven = isEvenNumber;
            bool result = isEven(10);
            Console.WriteLine(result);

            //Using anonymous function
            Predicate<int> isEven1 = delegate(int num) { if (num % 2 == 0) { return true; } else return false; };
            bool result1 = isEven1(21);

            //using lambda expression
            Predicate<int> isEven2 = num => { if (num % 2 == 0) { return true; } else return false; };
            bool result2 = isEven1(21);


        }

        //1.Normal
        static bool isEvenNumber(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }

    }
}
