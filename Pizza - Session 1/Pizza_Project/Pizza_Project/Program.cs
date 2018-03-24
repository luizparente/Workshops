using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PART A
            // Instantiating the Pizza Class
            Pizza pizza1 = new Pizza(Topping.Cheese, Size.XLarge);
            pizza1.Description = "No mushrooms.";

            Pizza pizza2 = new Pizza()
            {
                Topping = Topping.Salami,
                Size = Size.Medium,
                Description = "No olives."
            };

            Pizza pizza3 = new Pizza(Topping.Vegetarian, Size.Small);
            pizza3.Description = "Add bacon.";

            // Visualizing objects' info
            pizza1.GetInfo(true);
            pizza2.GetInfo(true);
            pizza3.GetInfo(true);

            #endregion

            #region PART B
            // Instantiating the Customer Class
            Customer customer1 = new Customer()
            {
                Name = "Frank Castle",
                PhoneNumber = "(647) 123 4567",
                CustomerAddress = new Address("Yonge Street", "0", "M4N 0A7", "Toronto", "Ontario")
            };

            // Visualizing objects' info
            customer1.GetInfo(true);

            #endregion

            #region PART C
            // Instantiating the Order Class
            Order order1 = new Order(customer1);

            // Visualizing objects' info
            order1.GetInfo();

            #endregion

            #region PART D
            // Adding pizzas to an order
            order1.AddPizza(pizza1, 2);
            order1.AddPizza(pizza2, 4);
            order1.AddPizza(pizza3, 1);

            // Visualizing updated order info
            order1.GetInfo();

            #endregion

            #region PART E
            // Instantiating Different Employee Classes

            // The statement below returns an error. Why?
            //Employee test = new Employee();

            Worker employee1 = new Worker("John Smith", "123456789", "(416) 123 4567", "Clerk", 3000.00)
            {
                EmployeeAddress = new Address("Markham Road", "8363", "M0K H1B", "Scarborough", "Ontario")
            };

            // Visualizing objects' info
            employee1.GetInfo(true);

            // Calling objects' methods
            employee1.Work();

            #endregion
        }
    }
}
