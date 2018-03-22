using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
      //Child class should not break parent class’s type definition and behavior.
      //Employee is a parent class and Casual and Contractual employee are the child classes, 
      //inhering from employee class.
    public abstract class Employee
    {
        public virtual string GetProjectDetails(int employeeId)
        {
            return "Base Project";
        }
        public virtual string GetEmployeeDetails(int employeeId)
        {
            return "Base Employee";
        }
    }
    public class CasualEmployee : Employee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }

        public override string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }
    public class ContractualEmployee : Employee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        // May be for contractual employee we do not need to store the details into database.    --Important Point--
        public override string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();       
        }
    }

    public class Driver
    {
        public static void Method()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new ContractualEmployee());
            employeeList.Add(new CasualEmployee());
            foreach (Employee e in employeeList)
            {
                e.GetEmployeeDetails(1245);//Yes right, for contractual employee, you will get not implemented exception and that is violating LSP.
            }
        }
    }

    //Resolution:
    //Yes right, for contractual employee, you will get not implemented exception and that is violating LSP.
    //Then what is the solution? Break the whole thing in 2 different interfaces, 1. IProject 2. IEmployee and
    //implement according to employee type.
    //Now, contractual employee will implement IEmployee not IProject. This will maintain this principle.

    public interface IEmployee
    {
        string GetEmployeeDetails(int employeeId);
    }

    public interface IProject
    {
        string GetProjectDetails(int employeeId);
    }
}
