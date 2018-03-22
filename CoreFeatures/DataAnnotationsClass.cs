using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //import assembly DataAnnotation
using System.ComponentModel;

namespace DataAnnotations
{
    class Employee
    {
        [Required(ErrorMessage="Its Required")]
        [StringLength(100,MinimumLength=3,ErrorMessage="String Length is not valid")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }

    class DataAnnotationsClass
    {
        //https://www.codeproject.com/Articles/826304/Basic-Introduction-to-Data-Annotation-in-NET-Frame
        //https://www.youtube.com/watch?v=Gft64NdIx3k 
        static void Method(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.Name = "s";
            objEmployee.PhoneNumber = 9965765443;
            objEmployee.Email = "test@re";

            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult vr in results)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Member Name :{0}", vr.MemberNames.First());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("   ::  {0}{1}", vr.ErrorMessage, Environment.NewLine);
                }
            }
        }
    }
}
