using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFeatures
{
    class MethodOverloading
    {
    }

    public class BaseClass1
    {
        public virtual void hello(int a, int b)
        {
        }
    }

    public class DerivedClass1 : BaseClass1
    {
      /*  public override int hello(int a, int b)
        {
            return 1;
        }*/
    }
}
