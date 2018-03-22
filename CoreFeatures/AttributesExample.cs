using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CoreFeatures
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HelloAttribute : Attribute   // We should inherit from Attribute class
    {
        public string HelpText { get; set; }
    }

    [Hello(HelpText = "This Method is attribute xxxx")]
    public class Example12 
    {        
        public string Name { get; set; }
    }

    public class Driver
    {
        public static void Method()
        {
            Example12 exampleObj = new Example12();

            Type info = exampleObj.GetType();
            object[] attributes = info.GetCustomAttributes(true);

            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine(attributes[i]);
            }
        }
    }
}
//op:  CoreFeatures.HelloAttribute

//Do attributes get inherited ?
//Yes, they get inherited in the child classes.