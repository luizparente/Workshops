using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project
{
    class Pizza
    {
        // Fields
        private readonly string pizzaID;
        private Topping topping;
        private Size size;
        private string description = "Please assign TOPPING and SIZE.";

        // Properties
        public string PizzaID
        {
            get
            {
                return pizzaID;
            }
            //set
            //{
            //    pizzaID = value;
            //}
        }
        public Topping Topping
        {
            get
            {
                return topping;
            }
            set
            {
                topping = value;
            }
        }
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        // Default Constructor
        public Pizza()
        {
            this.pizzaID = this.GetHashCode().ToString();
            Topping = Topping.Undefined;
            Size = Size.Undefined;
        }

        // Main Constructor
        public Pizza(Topping topping, Size size)
        {
            this.pizzaID = this.GetHashCode().ToString();
            Topping = topping;
            Size = size;
            Description = null;
        }

        // Methods
        public string GetInfo(bool print = false)
        {
            if (print == true)
            {
                Console.WriteLine("-----------------------------------------------\n" +
                    "             Info: Pizza {0}\n" +
                    "-----------------------------------------------\n\n" +
                    "Topping: {1}\n" +
                    "Size: {2}\n" +
                    "Description: {3}\n\n" +
                    "===============================================\n\n", PizzaID, Topping, Size, Description);

                return string.Format("Topping: {1}\n" +
                    "Size: {2}\n" +
                    "Description: {3}\n", PizzaID, Topping, Size, Description);
            }
            else
            {
                return string.Format("Topping: {1}\n\t\t Size: {2}\n\t\t Description: {3}\n", PizzaID, Topping, Size, Description);
            }
        }
    }
}
