using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class StringReverse
    {
        public static string recursive(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }   
            return recursive(str.Substring(1)) + str[0];
        }

        public static void UsingForloop(string str)
        {

            String reverse = "";

            for (int i = 0; i < str.Length; i++)
            {
                reverse = str[i] + reverse;
            }
            Console.WriteLine(reverse);
            
        }
    }
}
