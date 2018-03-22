using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFeatures
{
    class IEnumerableRepeatExample
    {
        public static void Method()
        {
            IEnumerable<string> strings = Enumerable.Repeat<string>("hello", 15);

            foreach (String str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
