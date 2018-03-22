using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Ref
//The ref keyword is used to pass an argument as a reference. This means that when value of that parameter 
//is changed in the method, it gets reflected in the calling method. An argument that is passed using a ref keyword must be initialized in the calling method before it is passed to the called method.

//1.1	Out
//The out keyword is also used to pass an argument like ref keyword, but the argument can be passed without 
//assigning any value to it. An argument that is passed using an out keyword must be initialized in the 
//called method before it returns back to calling method.

namespace General
{
    public class RefOutKeywords
    {
        public static void Method() //calling method
        {
            int val1 = 0; //must be initialized 
            int val2; //optional

            refMethod(ref val1);
            Console.WriteLine(val1); // val1=1

            outMethod(out val2);
            Console.WriteLine(val2); // val2=2
        }

        static void refMethod(ref int value) //called method
        {
            value = 1;
        }
        static void outMethod(out int value) //called method
        {
            value = 2; //must be initialized 
        }
    }

}
