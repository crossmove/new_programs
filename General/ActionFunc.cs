using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class ActionDelegate
    {
//Encapsulates a method that has a single parameter and does not return a value.
// Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Delegate
//	This Action<> generic delegate, points to a method that takes up to 16 Parameters and returns void.

        static void Method(string[] args)
        {
            Action<string, string, int> actionDel = ActionDelegate.ActionExample;
            actionDel("pradeep", "kumar", 21);
        }

        static void ActionExample(string firstName, string lastName, int id)
        {
            Console.WriteLine("Action Example " + firstName + lastName + id);
        }       

    }


//    ●	The generic Func<> delegate is used when we want to point to a method that returns a value.
//●	This delegate can point to a method that takes up to 16 Parameters and returns a value.
//●	Always remember that the final parameter of Func<> is always the return value of the method. (For example Func< int, int, string>, this version of the Func<> delegate will take 2 int parameters and returns a string value.)
//http://www.c-sharpcorner.com/UploadFile/ff0d0f/action-and-func-delegates-in-C-Sharp-net/

    class FuncDelegate
    {
        static void Method(string[] args)
        {
            Func<int, string> funcDel = FuncDelegate.FunctionExample;
            string value = funcDel(123456);

        }
        static string FunctionExample(int param)
        {
            Console.WriteLine("Func Example " + param);
            return param + "12341";
        }

    }
}
