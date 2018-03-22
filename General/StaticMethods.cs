using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
// 1.Instance methods can access static variable in the same class
//2.static methods can only access the static variables, static methods in the same class.
//3.static methods can call instance methods and variable of other classes.
//4.we cannot inherit the static class
//5.but we can inherit the instance class containing static methods, but only 
//instance members are visible to the derived class. i.e,, “this” keyword does not holds in static methods
 
//..
//1.we can use and declare non static variable in the static methods and use them
//2. the parameters of the static methods need not to be static, it can operate on it without any exception.

    class StaticMethods
    {
        public int InstanceVal;
        public const string staticVal = "21";
        public static string staticString;
        public int c;

        public void method1(int a, int b)
        {
            staticString = "21";
            //Instance methods can access static variable in the same class

        }
        public static void method2(int a, int b)
        {
            int c = 21;
            a = a + b;
            Console.WriteLine(c);
            staticString = "method2";
            string beda = staticVal;
        }
        public static void method3(int a, int b)
        {
            const string ahj = "21";
            string beda = staticVal;
            int c = 21;
            a = a + b;
            Console.WriteLine(staticString);

            Class2.method2();
            new Class2().method1();
            //static methods can only access the static variables, static methods
            //static methods can call instance methods and variable of other classes.
        }
    }

    public class Class2
    {
        public void method1()
        { }
        public static void method2()
        { }
    }

}
