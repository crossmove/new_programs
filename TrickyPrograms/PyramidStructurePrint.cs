using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class PyramidStructurePrint
    {
        public static void Print(int level)
        {
            int i, space, print;
            for (i = 1; i <= level; i++)
            {
                for (space = 1; space < (level - i + 1); space++)
                {
                    Console.Write(" ");
                }
                for (print = 1; print <= i; print++)
                {
                    Console.Write(i); // Console.Write("*"); replace this to print in asterik
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
