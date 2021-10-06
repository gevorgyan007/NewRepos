using DataAccessLayer.Models;
using WpfShered.Utility;

namespace CatalogModul.ViewModels
{
    public class CarViewModel
    {
        private Car car;

        public CarViewModel()
        {
        }

        public CarViewModel(Car car)
        {
            this.car = car;
            this.Make = car.Make;
            this.Model = car.Model;
            this.Color = car.Color;
            this.Price = car.Price;
            this.Year = car.Year;
        }

        public MakerType Make { get; set; }
        public ModelTypeCar Model { get; set; }
        public double Year { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
    }
}
