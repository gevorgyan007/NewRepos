using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfShered.Utility;

namespace CatalogModul.Implimentations
{
    public class Repository : IRepository
    {

        public Repository()
        {

        }
        public List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car(MakerType.Mercedes,ModelTypeCar.G55,2010,"Black",45000),
                new Car(MakerType.Mercedes,ModelTypeCar.E350,2015,"White",20000),
                new Car(MakerType.BMW,ModelTypeCar.X6,2011,"Yellow",18000),
                new Car(MakerType.Audi,ModelTypeCar.A8,2015,"Black",35000),
                new Car(MakerType.BMW,ModelTypeCar.F10,2010,"Black",22000),
                new Car(MakerType.Audi,ModelTypeCar.Q7,2014,"White",45000),
                new Car(MakerType.Mercedes,ModelTypeCar.GLE,2016,"Black",60000)
            };
        }
    }
}
