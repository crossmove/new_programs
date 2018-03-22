using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class StringLengthWithoutBuiltInFunction
    {
        public static void FindLenth(string Name)
        {
            StringBuilder str = new StringBuilder(Name);
            str.Append("\0");
            int i = 0;
            while(str[i] != '\0')
            {
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
