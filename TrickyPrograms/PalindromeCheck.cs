using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class PalindromeCheck
    {
        public static void Palindrome()
        {
            string palindromeStr = "malayalam";

            bool flag = true;

            for (int i = 0; i < (palindromeStr.Length /2); i++)
            {
                if (palindromeStr[i] != palindromeStr[palindromeStr.Length - (i+1)])
                {
                    Console.WriteLine("Not palindrome");
                    flag = false;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Given string is palindrome");
            }
        }
    }
}
