using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingExample
{
    class Customer
    {
        public bool AddCsutomer(MyEmail obj)
        {          
            obj.SendEmail();

            return true;

        }
    }

    public class MyEmail
    {
        public virtual bool SendEmail()  //mocking functions should be virtual
        {
            return true;
            //throw new Exception("SMTP server not configured yet");
        }
    }
}
