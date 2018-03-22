using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class PreFixPostFix
    {
        public static void method()
        {
            int i = 1;
            int j = i++;   //j = 1 , i = 2
            
            //in postfix : i++ : Assigns --> then Increment
            //in prefix  : ++i : Increment --> then Assigns

            int a = 1;
        }
    }
}
