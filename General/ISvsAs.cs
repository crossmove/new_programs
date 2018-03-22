using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The "is" operator is used to check whether the run-time type of an object is
 * compatible with a given type or not. It returns true if can be converted else false. 
 * 
 * The as operator can be only used with ‘Reference Types’ and Nullable Types.

https://www.youtube.com/watch?v=IKmRtJcRX_I
*/
namespace General
{
    class ISvsAs
    {
        public static void Method()
        {
            //IS
            Bird bird = new Bird();
            Parrot parrot = new Parrot();

            Console.WriteLine(parrot is Bird); //op: true
            Console.WriteLine(bird is Parrot); //op:  false

            //As
            Bird birdObj = parrot as Bird;
            Console.WriteLine(birdObj);         //op: General.Parrot

            Parrot parrotObj = bird as Parrot;
            //Check the Type using "is" 
            //If it’s true then Type cast , if false then Null
            Console.WriteLine("1" + parrotObj);   //op: Null
        }
    }

    class Bird { }
    class Parrot : Bird { }
}
