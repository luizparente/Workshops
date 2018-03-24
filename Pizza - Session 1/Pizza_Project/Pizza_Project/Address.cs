using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project
{
    public struct Address
    {
        // Fields
        public string streetName;
        public string streetNumber;
        public string zipCode;
        public string city;
        public string province;
        public string country;
        
        // Constructor
        public Address(string xstreetName,string xstreetNumber, string xzipCode, string xcity, string xprovince)
        {
            streetName = xstreetName;
            streetNumber = xstreetNumber;
            zipCode = xzipCode;
            city = xcity;
            province = xprovince;
            country = "Canada";
        }
    }
}
