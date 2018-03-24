using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project
{
    class Order
    {
        // Fields
        private readonly string orderID;
        private Customer customer;
        private Address orderAddress;
        private Pizza[] orderItems;
        private int[] itemQuantity;
        private int maxNumberOfItems = 10;
        private int maxQuantity = 10;
        private int currentNumberOfItems = 0;

        // Properties
        public string OrderID
        {
            get
            {
                return orderID;
            }
            //set
            //{
            //    orderID = value;
            //}
        }
        public Customer Customer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = value;
            }
        }
        public Address OrderAddress
        {
            get
            {
                return orderAddress;
            }
            set
            {
                orderAddress = value;
            }
        }

        // Default Constructor
        public Order()
        {
            this.orderID = this.GetHashCode().ToString();
        }

        // Main Constructor
        public Order(Customer person)
        {
            this.orderID = this.GetHashCode().ToString();
            Customer = person;
            OrderAddress = Customer.CustomerAddress;
            orderItems = new Pizza[maxNumberOfItems];
            itemQuantity = new int[maxQuantity];
        }

        // Methods
        public void AddPizza(Pizza pizza, int quantity)
        {
            orderItems[currentNumberOfItems] = pizza;
            itemQuantity[currentNumberOfItems] = quantity;
            currentNumberOfItems++;
        }

        public void GetInfo()
        {
            Console.WriteLine("-----------------------------------------------\n" +
                "              Info: Order {0}\n" +
                "-----------------------------------------------\n\n" +
                "Customer: {1}\n" +
                "Phone Number: {2}\n" +
                "Street Name: {3}\n" +
                "House/Apartment Number: {4}\n" +
                "Zip Code: {5}\n" +
                "City: {6}\n" +
                "Province: {7}\n" +
                "Country: {8}\n", OrderID, Customer.Name, Customer.PhoneNumber, Customer.CustomerAddress.streetName, Customer.CustomerAddress.streetNumber, Customer.CustomerAddress.zipCode, Customer.CustomerAddress.city, Customer.CustomerAddress.province, Customer.CustomerAddress.country);

            Console.WriteLine("{0, 12}{1, 24}" +
                "\n-----------------------------------------------", "QUANTITY", "ITEM INFO");

            for (int i = 0; i < currentNumberOfItems; i++)
            {
                Console.WriteLine("{0, 8}\t {1}", itemQuantity[i], orderItems[i].GetInfo(false));
            }

            Console.WriteLine("===============================================\n\n");
        }
    }
}
