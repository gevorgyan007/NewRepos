using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfShered.Utility;

namespace DataAccessLayer.Models
{
    public class Car 
    {
        public MakerType Make { get ; set; }   
        public ModelTypeCar Model { get ; set ; }
        public double Year { get ; set ; }    
        public string Color { get ; set ; }
        public double Price { get ; set ; }

        public Car(MakerType make, ModelTypeCar model, double year, string color, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Price = price;
        }

        public Car()
        {
        }
    }
}
