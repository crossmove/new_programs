using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    //‘If’ clauses are there and if we want to introduce another new report 
    //type like ‘Excel’, then you need to write another ‘if’. This class should 
    //be open for extension but closed for modification. But how to do that!!
    public class ReportGeneration
   {
        public string ReportType { get; set; }
        public void GenerateReport(Employee em)
        {
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }
            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }
    }

    //Resolution:
    //So if you want to introduce a new report type, then just inherit from IReportGeneration.
    //So IReportGeneration is open for extension but closed for modification.
    public class IReportGeneration
    {
        public virtual void GenerateReport(Employee em)
        {
            // From base
        }
    }

    public class CrystalReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            // Generate crystal report.
        }
    }

    public class PDFReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            // Generate PDF report.
        }
    }
}
