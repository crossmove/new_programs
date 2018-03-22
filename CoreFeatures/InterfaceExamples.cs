using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFeatures
{
    public interface IA
    {
        void car(int a);
    }

    public interface IB
    {
        void car(int a);
    }

    public class InterfaceImp : IA, IB
    {
        void IA.car(int a)               //We cannot use public modifiers as it implements interface throws error
        {
            Console.WriteLine("IA.car "+a);
        }

        void IB.car(int a)             //We cannot use public modifiers as it implements interface throws error
         {
             Console.WriteLine("IB.car "+a);
         }
    }

    public class InterfaceExamples
    {
        public void Method()
        {
            InterfaceImp obj = new InterfaceImp(); 
            //obj.            we cannot find car method using obj. 
            
            //So we need to assign to IA interface and then we can find the car method
            IA iobjA = new InterfaceImp();
            iobjA.car(1);

            IB iobjB = new InterfaceImp();
            iobjB.car(22);     
        }
    }
}
//op
/*IA.car 1
  IB.car 22*/