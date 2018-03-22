using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The protected keyword is a member access modifier. 
//A protected member is accessible within its class and by derived class instances.

namespace General
{
    class ProtectedClass
    {
        protected int x = 123;
    }

    class B : ProtectedClass
    {
        static void Method()
        {
            ProtectedClass a = new ProtectedClass();
            B b = new B();

            // Error CS1540, because x can only be accessed by
            // classes derived from A.
            // a.x = 10; 

            // OK, because this class derives from A.
            b.x = 10;
        }
    }

}
