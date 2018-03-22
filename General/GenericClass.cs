using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The most common use of generics is to create collection classes.
//●	Generics refers to the technique of writing the code for a class without
//specifying the data type(s) that the class works on. You specify the data type when you declare an instance of a generic class. This allows a generic class to be specialized for many different data types while only having to write the class once. 
//●	Reusability of the code
//●	Use generic types to maximize code reuse
//●	 type safety
//●	performance.

namespace General
{
    class GenericClass
    {
        public class GenericList<T> //where T : IDisposable
        {
            public T aa;
            public void Add(T input)
            {
                aa = input;
            }
        }

        class TestGenericList
        {
            static void Method()
            {
                // Declare a list of type int.
                GenericList<int> intlist = new GenericList<int>();


                // Declare a list of type string.
                GenericList<string> stringlist = new GenericList<string>();

                // Declare a list of type ExampleClass.  
                GenericList<ExampleClass> exampleClasslist = new
                GenericList<ExampleClass>();

                exampleClasslist.Add(new ExampleClass());
            }
        }
        public class ExampleClass
        { }
    }
}
