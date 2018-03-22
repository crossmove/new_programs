using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* ‘Employee’ class is taking 2 responsibilities, 1. employee database operation 2.Generate employee report.
 * Employee class should not take the report generation responsibility because suppose some days after your 
 * customer asked you to give a facility to generate the report in Excel or any other reporting format, then
 * this class will need to be changed and that is not good.
 * 
 * 
 * */
namespace SOLID_Principles
{
    public class Employee_SR
    {
        public bool InsertIntoEmployeeTable(Employee_SR em)
        {
            // Insert into employee table.
            return true;
        }

        //
        public void GenerateReport(Employee em)
        {
            // Report generation with employee data using crystal report.
        }
    } 
    
    //Resolution: 
        
    /*So according to SRP, one class should take one responsibility so we should write one different 
     * class for report generation, so that any change in report generation should not affect the ‘Employee’ class.
     * 
     **/

    public class ReportGeneration_SR
    {
        public void GenerateReport(Employee_SR em)
        {
            // Report reneration with employee data.
        }
    }
}
