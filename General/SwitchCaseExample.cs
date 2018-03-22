using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class SwitchCaseExample
    {
        public static void method()
        {
            char grade = 'B';

            switch(grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;

                case 'B':
                case 'C':
                    Console.WriteLine("Well done");
                    break;   
            
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine("Your grade is  {0}", grade);
        }

    }
}
