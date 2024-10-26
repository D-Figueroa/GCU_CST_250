using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        // Properties for the Car with getters and setter.
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }


        // Constructs a car using properties
        public Car(string make, string model, int year, decimal price, string color, int miles) { 
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Color = color;
            Miles = miles;

        }

        // Default constructor when no properties are input.
        public Car() {
            Make = "Nothing yet";
            Model = "Nothing yet";
            Year = 0;
            Price = 0;
            Color = "Nothing yet";
            Miles = 0;
        }

        // Outputs Car object to a string.
        override
        public string ToString()
        {
            return (Year + " " +  Color + " " + Make + " " + Model + ", with " + Miles + " miles - $" + Price);
        }
    }
}
