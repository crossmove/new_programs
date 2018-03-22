using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class SortLinq
    {
        public static void Method()
        {
            string[] strarray = { "d", "b", "c" };

            var x = strarray.OrderBy<string, int>(abc => abc.Length);
        }
    }
}
