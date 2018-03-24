using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project
{
    abstract class Employee
    {
        // Fields
        private readonly string employeeID;
        private string name;
        private string sinNumber;
        private Address employeeAddress;
        private string phoneNumber;
        private string position;

        // Properties
        public string EmployeeID
        {
            get
            {
                return employeeID;
            }
            //set
            //{
            //    employeeID = value;
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
        public string SinNumber
        {
            get
            {
                return sinNumber;
            }
            //set
            //{
            //    sinNumber = value;
            //}
        }
        public Address EmployeeAddress
        {
            get
            {
                return employeeAddress;
            }
            set
            {
                employeeAddress = value;
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
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

        // Default Constructor
        public Employee()
        {
            this.employeeID = this.GetHashCode().ToString();
            Name = null;
            this.sinNumber = null;
            PhoneNumber = null;
            Position = null;
        }

        // Main Constructor
        public Employee(string name, string sinNumber, string phone, string position)
        {
            this.employeeID = this.GetHashCode().ToString();
            Name = name;
            this.sinNumber = sinNumber;
            PhoneNumber = phone;
            Position = position;
        }

        // Methods
        public virtual string GetInfo(bool print = false)
        {
            if (print == true)
            {
                Console.WriteLine("-----------------------------------------------\n" +
                    "           Info: Employee {0}\n" +
                    "-----------------------------------------------\n\n" +
                    "Name: {1}\n" +
                    "Sin Number: {2}\n" +
                    "Position: {3}\n" +
                    "Phone Number: {4}\n" +
                    "Street Name: {5}\n" +
                    "House/Apartment Number: {6}\n" +
                    "Zip Code: {7}\n" +
                    "City: {8}\n" +
                    "Province: {9}\n" +
                    "Country: {10}\n\n" +
                    "===============================================\n\n", EmployeeID, Name, SinNumber, Position, PhoneNumber, EmployeeAddress.streetName, EmployeeAddress.streetNumber, EmployeeAddress.zipCode, EmployeeAddress.city, EmployeeAddress.province, EmployeeAddress.country);

                return string.Format("Name: {0}\n" +
                    "Sin Number: {1}\n" +
                    "Position: {2}\n" +
                    "Phone Number: {3}\n" +
                    "Street Name: {4}\n" +
                    "House/Apartment Number: {5}\n" +
                    "Zip Code: {6}\n" +
                    "City: {7}\n" +
                    "Province: {8}\n" +
                    "Country: {9}\n\n" +
                    "===============================================\n\n", Name, SinNumber, Position, PhoneNumber, EmployeeAddress.streetName, EmployeeAddress.streetNumber, EmployeeAddress.zipCode, EmployeeAddress.city, EmployeeAddress.province, EmployeeAddress.country);
            }
            else
            {
                return string.Format("Name: {0}\n" +
                    "Sin Number: {1}\n" +
                    "Position: {2}\n" +
                    "Phone Number: {3}\n" +
                    "Street Name: {4}\n" +
                    "House/Apartment Number: {5}\n" +
                    "Zip Code: {6}\n" +
                    "City: {7}\n" +
                    "Province: {8}\n" +
                    "Country: {9}\n\n" +
                    "===============================================\n\n", Name, SinNumber, Position, PhoneNumber, EmployeeAddress.streetName, EmployeeAddress.streetNumber, EmployeeAddress.zipCode, EmployeeAddress.city, EmployeeAddress.province, EmployeeAddress.country);
            }
        }

        public abstract void Work();
    }
}
