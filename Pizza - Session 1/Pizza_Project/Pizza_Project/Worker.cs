using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project
{
    class Worker : Employee
    {
        // Fields
        private readonly double salary;

        // Properties
        public double Salary
        {
            get
            {
                return salary;
            }
        }

        // Default Constructor
        public Worker() : base()
        {
            this.salary = 0;
        }

        // Main Constructor
        public Worker(string name, string sinNumber, string phone, string position, double salary) : base(name, sinNumber, phone, position)
        {
            this.salary = salary;
        }

        // Methods
        public override string GetInfo(bool print = false)
        {
            if (print == true)
            {
                Console.WriteLine("-----------------------------------------------\n" +
                    "           Info: Employee {0}\n" +
                    "-----------------------------------------------\n\n" +
                    "Name: {1}\n" +
                    "Sin Number: {2}\n" +
                    "Position: {3}\n" +
                    "Salary: {4}\n" +
                    "Phone Number: {5}\n" +
                    "Street Name: {6}\n" +
                    "House/Apartment Number: {7}\n" +
                    "Zip Code: {8}\n" +
                    "City: {9}\n" +
                    "Province: {10}\n" +
                    "Country: {11}\n\n" +
                    "===============================================\n\n", EmployeeID, Name, SinNumber, Position, Salary, PhoneNumber, EmployeeAddress.streetName, EmployeeAddress.streetNumber, EmployeeAddress.zipCode, EmployeeAddress.city, EmployeeAddress.province, EmployeeAddress.country);

                return string.Format("Name: {0}\n" +
                    "Sin Number: {1}\n" +
                    "Position: {2}\n" +
                    "Salary: {3}" +
                    "Phone Number: {4}\n" +
                    "Street Name: {5}\n" +
                    "House/Apartment Number: {6}\n" +
                    "Zip Code: {7}\n" +
                    "City: {8}\n" +
                    "Province: {9}\n" +
                    "Country: {10}\n\n" +
                    "===============================================\n\n", Name, SinNumber, Position, Salary, PhoneNumber, EmployeeAddress.streetName, EmployeeAddress.streetNumber, EmployeeAddress.zipCode, EmployeeAddress.city, EmployeeAddress.province, EmployeeAddress.country);
            }
            else
            {
                return string.Format("Name: {0}\n" +
                    "Sin Number: {1}\n" +
                    "Position: {2}\n" +
                    "Salary: {3}" +
                    "Phone Number: {4}\n" +
                    "Street Name: {5}\n" +
                    "House/Apartment Number: {6}\n" +
                    "Zip Code: {7}\n" +
                    "City: {8}\n" +
                    "Province: {9}\n" +
                    "Country: {10}\n\n" +
                    "===============================================\n\n", Name, SinNumber, Position, Salary, PhoneNumber, EmployeeAddress.streetName, EmployeeAddress.streetNumber, EmployeeAddress.zipCode, EmployeeAddress.city, EmployeeAddress.province, EmployeeAddress.country);
            }
        }

        public override void Work()
        {
            Console.WriteLine("-----------------------------------------------\n" +
                "I am a happy worker.\n" +
                "-----------------------------------------------\n\n");
        }
    }
}
