using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class InterleavingCharactersOfStrings
    {
        //https://codereview.stackexchange.com/questions/174420/interleaving-two-strings

        public static void method()
        {
            string string1 = "ABC";
            string string2 = "123";
            for (int j = 0; j < string1.Length || j < string2.Length; j++)
            {
                if (j < string1.Length)
                {
                    Console.Write(string1[j]);
                }
                if (j < string2.Length)
                {
                    Console.Write(string2[j]);
                }
            }
            Console.WriteLine();
        }
    }
}
