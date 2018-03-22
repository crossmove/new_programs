using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
//An enum is a value type with a set of related named constants often referred to as an enumerator list.
//Usually it is best to define an enum directly within a namespace so that all classes in the namespace 
//can access it with equal convenience. However, an enum can also be nested within a class or struct.

    class EnumExample
    {
        public enum DayofWeek
        {
            //by default all members of enum are public, we cannot use access modifiers inside enum
            Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        static void Method(string[] args)
        {
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Sunday, DayofWeek.Sunday);

            string[] names = Enum.GetNames(typeof(DayofWeek));

            foreach (string s in names)
            {
                Console.WriteLine(s);
            }

            int[] vals = (int[])Enum.GetValues(typeof(DayofWeek));
            foreach (int s in vals)
            {
                Console.WriteLine(s);
            }
        }

    }
}
