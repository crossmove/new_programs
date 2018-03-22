using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    class Class1
    {
        public void method()
        {
            // Create a new derived type.  
            Giraffe g = new Giraffe();

            // Implicit conversion to base type is safe.  
            Animal a = g;

            // Explicit conversion is required to cast back  
            // to derived type. Note: This will compile but will  
            // throw an exception at run time if the right-side  
            // object is not in fact a Giraffe.  
            Giraffe g2 = (Giraffe)a;
        }
    }
    class Animal
    {
    }

    class Giraffe: Animal
    {
    }
   
}
