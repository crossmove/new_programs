//Virtual and Override and new Keyword:

//When used as a declaration modifier, the new keyword explicitly hides a member that is inherited from a base class. 
//new = hide
using System;
namespace Generics
{
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("Base Class");
            //Console.ReadLine();
        }
    }

    class B : A
    {
        public override void show()
        {
            Console.WriteLine("Override in Derived Class");
            //Console.ReadLine();
        }
    }

    class C : A
    {
        public new void show()
        {
            Console.WriteLine("Class c with New Keyword instead of Override");
            //Console.ReadLine();
        }
    }

    class Polymorphism
    {
        public static void Method()
        {
            A a1 = new A();
            a1.show();

            B b1 = new B();
            b1.show();

            A a2 = new B();
            a2.show();

            C c1 = new C();
            c1.show();

            A c2 = new C();
            c2.show();

        }
    }
}
