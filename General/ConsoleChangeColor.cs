using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class ConsoleChangeColor
    {
        public static void Method()
        {
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), "4");
            Console.WriteLine("Paapu");
        }
    }
}
