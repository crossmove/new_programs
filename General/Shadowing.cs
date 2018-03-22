using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class Shadowing
    {
        public static void Driver()
        {
            Base baseObj = new Base();
            baseObj.virt();
            baseObj.shadow();

            Console.WriteLine("\n");

            Derived DerivedObj = new Derived();
            DerivedObj.virt();
            DerivedObj.shadow();

            Console.WriteLine("\n");

            //Shadow Implementation
            Base shadowObj = new Derived();
            shadowObj.virt(); //this will call Derived class Virt method : op "Derived: Virtual"
            Console.BackgroundColor = ConsoleColor.DarkRed;

            //It has called the base class shadow() method not derived class,
            //it is because we have defined "Derived" class method with new keyword which is hiding the derived 
            //class method when we are calling it with object of type "Base" which is our base class,
            shadowObj.shadow();
        }
    }

    public class Base
    {
       public virtual void virt()
        {
            Console.WriteLine("Base: Virtual");
        }

       public void shadow()
       {
           Console.WriteLine("Base: Shadow");
       }
    }

    public class Derived : Base
    {
        public override void virt()
        {
            Console.WriteLine("-----Derived: Virtual-----");
        }

        public new void shadow() //if we dont use new keyword, it throws only warining but output will be same
        {
            Console.WriteLine("----Derived: shadow-------");
        }
    }
}
