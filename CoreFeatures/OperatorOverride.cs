using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFeatures
{
    class OperatorOverrideClass
    {
        internal string ID;

        //Atlease one of the parameter for OperatorOverride should be containing class, here it is "OperatorOverrideClass"
        public static string operator *(OperatorOverrideClass a, int b) //Here * is overrloading operator
        {
            return a.ID + b;
        }
    }
    class OperatorOverride
    {
        public static void Method()
        {
            OperatorOverrideClass x = new OperatorOverrideClass() { ID = "pradeep_" };
            //Here we are using * as operator for opernands 
            var val = x * 1; //We are adding two objects of type OperatorOverride
                                                   //which is not possible without usign operator override
            Console.WriteLine(val);
        }
    }
}
