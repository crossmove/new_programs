using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class SecondHighestSalaryLinq
    {
        static List<Employee> list = new List<Employee> { 
            new Employee { ID = 1, Name = "pradeep", Salary = 1000 },  //4
            new Employee { ID = 2, Name = "kumar", Salary = 5000 },    //1
            new Employee { ID = 3, Name = "raju", Salary = 4000 },     //2
            new Employee { ID = 4, Name = "vijau", Salary = 4000 },    //2
            new Employee { ID = 5, Name = "Deepu", Salary = 3000 }     //3
        };
        
     
        public static void method(int highest)
        {
            highest = highest - 1; //for skipping purpose we are minising 1 

            var secondHighest = list.OrderByDescending(a => a.Salary).GroupBy(a => a.Salary).Skip(highest).First();
            Console.WriteLine(secondHighest.First().Name + " " + secondHighest.First().Salary);

            //Select returns only the selected(think as column) values
            var onlySalary = list.OrderByDescending(a => a.Salary).Select(x => x.Salary);

            foreach (var item in onlySalary)
            {
                Console.WriteLine(item);
            }            
        }
    }


    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
