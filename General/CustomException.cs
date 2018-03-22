using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    //Implement Exception or ApplicationException and write the excpetion handling methods.
    class CustomExceptionXX : Exception  // or use ApplicationException
    {
        public void ExceptionABC()
        {
            Console.WriteLine("");
        }
        public void ExceptionXYZ()
        {
            Console.WriteLine("");
        }
    }

    public class CustomExceptionDriver
    {
        public static void Method()
        {
            try
            {
                int b = 0;
                int div = 1/b;

                if (div == 0)
                {
                    throw new CustomExceptionXX();    //throw new CustomException
                }
            }
            catch(CustomExceptionXX custExp)        //Catch the custom exception
            {
                custExp.ExceptionABC();             //Call the exception handler method
            }
        }
    }
}
