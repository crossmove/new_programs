using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class ConstantsReadonly
    {
        //Constants are accessed like static fields because the value of the constant 
        //is the same for all instances of the type. 
        public const int ID = 20;

        public readonly double pi = 3.14;

        public ConstantsReadonly(int val)
        {
            pi = val; 
        }
    }
}
