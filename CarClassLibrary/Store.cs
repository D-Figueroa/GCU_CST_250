using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> CarList {  get; set; }
        public List<Car> ShoppingList {  get; set; }

        // Constructor initializes the Car List and SHoppingList properties
        public Store() { 
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        // Finds the total of everything in the shopping cart
        public decimal Checkout()
        {
            decimal total = 0;
            foreach (Car car in ShoppingList)
            {
                total += car.Price;
            }
            return total;
        }
    }
}
