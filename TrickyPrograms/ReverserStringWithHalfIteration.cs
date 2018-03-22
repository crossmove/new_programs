using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class ReverserStringWithHalfIteration
    {
        static void Main(string[] args)
        {
            string string1 = "ABCD12345";

            char[] charArray = string1.ToCharArray();

            char temp;

            for (int i = 0; i < charArray.Length / 2; i++)
            {
                temp = charArray[i];
                charArray[i] = charArray[(charArray.Length - 1) - i];
                charArray[(charArray.Length - 1) - i] = temp;
            }
            Console.WriteLine(new String(charArray));
        }
}

