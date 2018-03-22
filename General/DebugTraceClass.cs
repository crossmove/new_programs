using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Required 
// 1. Visual Studio Menu --> Debug --> Windows --> Output
// 2. Visual Studio Menu --> Edit --> Output
// 3. Run the code
// 4. In the output windows, change to Show output from to "Debug"
// 5. This Debug will work only in Debug mode for release mode its ignored

//The Debug and Trace classes have very similar methods. The primary difference 
//is that calls to the  Debug class are typically only included in Debug build 

//and Trace are included in all builds (Debug and Release). 

namespace General
{
    class DebugTraceClass
    {
        public static void method()
        {
            Debug.WriteLine("Today is Sunday");
            
            int a = 1;
            Debug.Assert(a > 2 ," a error"); //if the  condition is wrong this will show error popup

            Debug.WriteLineIf(a == 5, "Error Debugging"); //if the conditon is false , then it writes the error message in Debug window

            Debug.Indent();
            Debug.Write("Hello Good Morning");
            Debug.Unindent();
            
        }
    }
}
