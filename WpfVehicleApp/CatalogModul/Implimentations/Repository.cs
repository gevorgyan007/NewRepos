using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogModul.Implimentations
{
    public class Repository : IRepository
    {
        private static List<Make> makes = new List<Make>
        {
            new Make
            {
                Name = "Mercedes",
                Models =new List<Model>{ new Model {Name = "E350"}, new Model { Name = "G55" }, new Model { Name = "GLE" } }
            },
            new Make
            {
                Name = "BMW",
                Models =new List<Model>{ new Model {Name = "X6"}, new Model { Name = "F10" }, new Model { Name = "F30" } }
            },
            new Make
            {
                Name = "Audi",
                Models =new List<Model>{ new Model {Name = "A8"}, new Model { Name = "Q7" } }
            }
        };

        private List<Car> cars = new List<Car>
        {
               new Car()
               {
                   Makes = makes[0],
                   Year = 2010,
                   Price = 20000,
                   Color = "Black",
                   Models = new Model(){Name = "E350" }
               }
                ,
                new Car()
                {
                    Makes = makes[0],
                    Year = 2010,
                    Price = 20000,
                    Color = "White",
                    Models = new Model(){Name = "G55" }
                },
                new Car()
                {
                    Makes = makes[0],
                    Year = 2010,
                    Price = 20000,
                    Color = "Black",
                    Models = new Model(){Name = "GLE" }
                },
                new Car()
                {
                    Makes = makes[1],
                    Year = 2011,
                    Price = 21000,
                    Color = "Blue",
                    Models = new Model(){Name = "X6" }
                },
                new Car()
                {
                    Makes = makes[1],
                    Year = 2016,
                    Price = 25000,
                    Color = "Red",
                    Models = new Model(){Name = "F10" }
                },
                new Car()
                {
                    Makes = makes[1],
                    Year = 2017,
                    Price = 19500,
                    Color = "Black",
                    Models = new Model(){Name = "F30" }
                },
                new Car()
                {
                    Makes = makes[2],
                    Year = 2013,
                    Price = 32000,
                    Color = "Black",
                    Models = new Model(){Name = "Q7" }
                },
                new Car()
                {
                   Makes = makes[2],
                    Year = 2018,
                    Price = 48000,
                    Color = "Black",
                    Models = new Model(){Name = "A8" }
                }
            };

        public List<Car> GetCars()
        {
            return cars;
        }

        public List<Make> GetMakes()
        {
            return makes;
        }

        public IEnumerable<Car> GetCars(Model filter)
        {
            return cars.Where(c => c.Models == filter);
        }
        
    }
}
