using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
//    One key difference between abstract classes and interfaces is that a class
//    may implement an unlimited number of interfaces, but may inherit from only one abstract (or any other kind of) class.
//1.	Abstract class have abstract modifier.
//2.	If  the abstract class may or may not contain abstract methods.
//3.	If the abstract method is declared, than the class should be abstract.
//4.	The abstract method should be override in the derived class.
//5.	The override abstract method must follow the same signature defined in the abstract class. 

    abstract class AbstractClass
    {
        internal abstract void AbstractMethod1();
        public void NonAbstractMethod1()
        {
            Console.WriteLine("nonabstractmethod1");
        }
    }
    internal class DeriviedClass : AbstractClass
    {
        internal override void AbstractMethod1()
        {

        }
    }

}
