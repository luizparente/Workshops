using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project
{
    class Customer
    {
        // Fields
        private readonly string customerID;
        private string name;
        private string phoneNumber;
        private Address customerAddress;

        // Properties
        public string CustomerID
        {
            get
            {
                return customerID;
            }
            //set
            //{
            //    customerID = value;
            //}
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public Address CustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                customerAddress = value;
            }
        }
        
        // Default Constructor
        public Customer()
        {
            this.customerID = this.GetHashCode().ToString();
            Name = null;
            PhoneNumber = null;
            CustomerAddress = new Address(null, null, null, null, null);
        }

        // Main Constructor
        public Customer(string name, string phoneNumber, string streetName, string streetNumber, string zipCode, string city, string province)
        {
            this.customerID = this.GetHashCode().ToString();
            Name = name;
            PhoneNumber = phoneNumber;
            CustomerAddress = new Address(streetName, streetNumber, zipCode, city, province);
        }

        // Methods
        public string GetInfo(bool print = false)
        {
            if (print == true)
            {
                Console.WriteLine("-----------------------------------------------\n" +
                    "           Info: Customer {0}\n" +
                    "-----------------------------------------------\n\n" +
                    "Name: {1}\n" +
                    "Phone Number: {2}\n" +
                    "Street Name: {3}\n" +
                    "House/Apartment Number: {4}\n" +
                    "Zip Code: {5}\n" +
                    "City: {6}\n" +
                    "Province: {7}\n" +
                    "Country: {8}\n\n" +
                    "===============================================\n\n", CustomerID, Name, PhoneNumber, CustomerAddress.streetName, CustomerAddress.streetNumber, CustomerAddress.zipCode, CustomerAddress.city, CustomerAddress.province, CustomerAddress.country);

                return string.Format("Name: {0}\n" +
                    "Phone Number: {1}\n" +
                    "Street Name: {2}\n" +
                    "House/Apartment Number: {3}\n" +
                    "Zip Code: {4}\n" +
                    "City: {5}\n" +
                    "Province: {6}\n" +
                    "Country: {7}\n\n" +
                    "===============================================\n\n", Name, PhoneNumber, CustomerAddress.streetName, CustomerAddress.streetNumber, CustomerAddress.zipCode, CustomerAddress.city, CustomerAddress.province, CustomerAddress.country);
            }
            else
            {
                return string.Format("Name: {0}\n" +
                    "Phone Number: {1}\n" +
                    "Street Name: {2}\n" +
                    "House/Apartment Number: {3}\n" +
                    "Zip Code: {4}\n" +
                    "City: {5}\n" +
                    "Province: {6}\n" +
                    "Country: {7}\n\n" +
                    "===============================================\n\n", Name, PhoneNumber, CustomerAddress.streetName, CustomerAddress.streetNumber, CustomerAddress.zipCode, CustomerAddress.city, CustomerAddress.province, CustomerAddress.country);
            }
        }
    }
}
