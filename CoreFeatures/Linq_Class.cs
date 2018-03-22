using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFeatures
{
    class Linq_Class
    {
        public static void Method()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            IEnumerable<int> resutl = list.Where(elem => elem > 2); //Consider this as for each loop functionality

            //It is similar to a foreach loop: foreach(Student s in studentList).
            //Query Syntax starts with from clause and can be end with Select or GroupBy clause.
            //var can be used to hold the result of the LINQ query.
            IEnumerable<int> resut2 = from elem in list
                                      where elem > 2
                                      select elem;    // it returns only elements not list

            foreach (var item in resut2)
            {
                Console.WriteLine(item);    
            }
            
            
        }
    }
}
//FirstOrDefault()
