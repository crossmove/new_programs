using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class TypeOfvsGetType
    {
        public void Method()
        {
            Home homeObj = new Home();
            Console.WriteLine(homeObj.GetType());
            //GetType gets resolved at runtime.

            //typeof is resolved at compile time.
            Type typeOfObj = typeof(Home);
            Console.WriteLine(typeOfObj);
        }
    }

    class Home
    {
        
    }
}
