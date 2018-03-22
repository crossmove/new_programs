using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFeatures
{    
    public class baseClass2
    {
        public virtual void Method()
        {
        }
    }

    class derivedClass2 : baseClass2
    {
        public sealed override void Method()
        {
            Console.WriteLine("Sealed method");
        }
    }

    //Remove Comments will throw error
    class derivedClass3 : derivedClass2
    {
       /* override public void Method() //Error: cannot override inherited member  
        {                             //B.printA() because it is sealed.   

        }*/
    } 
}
