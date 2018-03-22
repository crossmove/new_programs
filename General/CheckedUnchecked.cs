using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class CheckedUnchecked
    {
        public static void Checked()
        {
            int x = 2147483647;
            int y = 2147483647;

             
             int result = (x + y);
             Console.WriteLine(result); // op: -2 which is not valid 
             
            //if you add checked keyword it will throws exception it there is a overlflow
             int check = checked(x + y);
        }
        

        public static void UnChecked()
        {
            int x = 2147483647;
            int y = 2147483647;


            int result = (x + y);
            Console.WriteLine(result); // op: -2 which is not valid 

            //Unchecked Keyword works as default behaviour 
            int uncheckResult = unchecked(x + y);
            Console.WriteLine(result); // op: -2 which is same result of default behaviour


            //Unchecked actual usage comes with constants
            const int a = 2147483647;
            const int b = 2147483647;

            //int c = a + b;
            //Above line throws compile time error in order to skip compile time overflow we will use unchecked keyword
            //as shown below
            int c = unchecked(a + b);
        }
    }
}
