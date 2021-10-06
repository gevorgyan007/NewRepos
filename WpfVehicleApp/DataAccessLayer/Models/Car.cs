using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Car
    {
        public Make Makes { get; set; }
        public Model Models { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public Car()
        {

        }

        public Car(Make makes, Model models, int year, string color, double price)
        {
            Makes = makes;
            Models = models;
            Year = year;
            Color = color;
            Price = price;
        }
    }
}
