using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://www.tutorialsteacher.com/csharp/csharp-covariance-and-contravariance
// 1. Covariance can be applied on delegate, generic, array, interface, etc
// 2. Covariance enables you to pass a derived type where a base type is expected
// 3. We can use Covariance and Contravariance in single method
namespace CoreFeatures
{

    public delegate BaseClass covarDel(DerivedClass mc);

    class CovarianceContravariance
    {
         static DerivedClass Method1(DerivedClass bg)
        {
            Console.WriteLine("Method1");

            return new DerivedClass();
        }

         #region ForContravarianceExample
         static BaseClass Method2(DerivedClass bg)
        {
            Console.WriteLine("Method2");

            return new BaseClass();
        }

         static BaseClass Method3(BaseClass sml)
         {
             Console.WriteLine("Method3");

             return new BaseClass();
         }
         #endregion ForContravarianceExample

         public static void CovarianceExample()
        {
            covarDel del = Method1;

            //delegate expects a return type of small (base class) but we can still assign Method1 that returns Big (derived class)
            BaseClass sm = del(new DerivedClass());
        }

       public static void ContravarianceExample()
       {
           covarDel del = Method1;
           del += Method2;
           del += Method3;

           Console.WriteLine("\n\nContravariance output");
           BaseClass sm = del(new DerivedClass());
           //you can see, Method3 has a parameter of Base class whereas delegate
           //expects a parameter of Derived class. Still, you can use Method3 with the delegate

       }
    }
    public class BaseClass
    {

    }
    public class DerivedClass : BaseClass
    {

    }
}
/*
 * Co-variance is like variance of the same kind. The base class and other derived classes are considered to be 
 * the same kind of class that adds extra functionalities to the base type. So covariance allows you to use a derived 
 * class where a base class is expected (rule: can accept big if small is expected).
 */
