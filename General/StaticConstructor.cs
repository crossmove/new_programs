using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    //static constructor should be  parameterless. It is invoked only once, i.e,,
    //when creating the first instance of the that class. Static constructor is used
    //to initialize only the static variables.

    
    static class StaticClassExample
    {
        private static string VersionPath;

        static StaticClassExample()
        {
            VersionPath = @"C:\deploy\CaligoBuildVersion.txt";
        }

        //imp
        //The below line throws error, cannot declare instance members inside static class
       // public int Id { get; set; }

       
        //if you add paramters to Static Constructor it shows compile time errror 
        //"Static constructor should  be parameterless" , so below example commented 
        /*
        static StaticClassExample(int a)
        {           
        } 
         * */
    }
}
