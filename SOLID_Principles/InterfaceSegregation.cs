using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    //This principle states that any client should not be forced to use an interface
    //which is irrelevant to it.

    //Now what does this mean, suppose there is one database for storing data of all types of employees
    //(i.e. Permanent, non-permanent), now what will be the best approach for our interface?

    /* And all types of employee class will inherit this interface for saving data. 
         This is fine right? */
    public interface IEmployee_IS   //IS = InterfaceSegregation
    {
        bool AddEmployeeDetails();      
    }

    /*
     Now suppose that company one day told to you that they want 
     * to read only data of permanent employees. What you will do, just add one method to this interface?

     * But now we are breaking something. We are forcing non-permanent employee class to show their details
     * from database.
     * */
    public interface IEmployeeDatabase
    {
        bool AddEmployeeDetails();
        bool ShowEmployeeDetails(int employeeId);
    }

    // So, the solution is to give this responsibility to another interface.
    // And non-permanent employee will implement only IAddOperation and 
    // permanent employee will implement both the interface.
    public interface IAddOperation
    {
        bool AddEmployeeDetails();
    }
    public interface IGetOperation
    {
        bool ShowEmployeeDetails(int employeeId);
    }    
}
