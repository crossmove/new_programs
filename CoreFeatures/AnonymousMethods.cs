using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Anonymous method must be assigned to a delegate.
//2. Anonymous method can be passed as a parameter.
//3. Anonymous method can be used as event handlers.
namespace CoreFeatures
{
    public delegate int Square(int num); //Delegate Name is Square
 
    class AnonymousMethods
    {
       static int i = 0;

       static Square sqr = delegate(int num) //Here we decalared method as per the signature of delegate (input and return type)
        {
            Console.WriteLine(num * num);
            i = 21;                        //Anonymous methods can access variables defined in an outer function.   
            return num * num;
        };

        public static void Method()
        {
            sqr.Invoke(5); //both syntax are correct
            //or
            sqr(6);
        }
    }
}
