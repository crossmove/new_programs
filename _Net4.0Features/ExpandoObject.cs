using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class ExpandoObject
    {
        public void Example()
        {
            dynamic Person = new ExpandoObject();
            Person.ID = 1001;
            Person.Name = "firstName";
            Person.LastName = "lastname";
            Person.Address = "Bangalore";

            Console.WriteLine(Person.address);

            // ExpandoObject contact = new ExpandoObject();       
        }
    }
}
