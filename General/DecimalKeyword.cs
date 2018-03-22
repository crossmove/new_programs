using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The decimal keyword indicates a 128-bit data type. Compared to floating-point types, 
//the decimal type has more precision and a smaller range, which makes it appropriate for
//financial and monetary calculations
//If you want a numeric real literal to be treated as decimal, use the suffix m or M, for example:

//Double: The double keyword signifies a simple type that stores 64-bit floating-point values.
//Float:The float keyword signifies a simple type that stores 32-bit floating-point values.

//By default, a real numeric literal on the right side of the assignment operator is treated as double. 

//int: 32 bit 

namespace General
{
    class DecimalKeyword
    {
        public void Method()
        {
            //for decimal m / M suffix
            decimal myMoney = 300.5m;

            double money = 500.133;

            //for decimal f / F suffix
            float cash = 500.5F;          

        }
    }
}
