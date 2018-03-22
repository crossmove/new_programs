using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    public class ReverseNumber
    {
        public static void reverse()
        {
            int number = 12345;
            int reverse = 0;
            int reminder;
            while (number > 0)
            {
                reminder = number % 10;
                reverse = reverse * 10 + reminder;
                number = number / 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
