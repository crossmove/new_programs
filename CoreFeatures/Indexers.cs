using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFeatures
{
    //https://www.youtube.com/watch?v=HdtEQqu0yOY
    public class Indexers
    {
        private List<Address> addressList = new List<Address>();
        public Indexers()
        {
            addressList.Add(new Address() { PinCode = 1, MobileNumber = "9964" });
            addressList.Add(new Address() { PinCode = 2, MobileNumber = "9845" });
        }

        public Address this[int pin]
        {
            get
            {
                foreach (var address in addressList)
                {
                    if(address.PinCode == pin)
                    {
                        return address;
                    }
                }
                return null;
            }
        }
        public Address this[string mobileNum]
        {
            get
            {
                foreach (var address in addressList)
                {
                    if (address.MobileNumber.Equals(mobileNum))
                    {
                        return address;
                    }
                }
                return null;
            }
        }
    }
    public class Address
    {
        public int PinCode { get; set; }
        public string MobileNumber { get; set; }
    }
}
