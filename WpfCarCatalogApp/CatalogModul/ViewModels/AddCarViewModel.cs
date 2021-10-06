using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfShered.EventModels;
using WpfShered.Events;
using WpfShered.Utility;

namespace CatalogModul.ViewModels
{
    public class AddCarViewModel : BindableBase
    {
        private readonly IEventAggregator eventAggregate;
        private MakerType make;
        private ModelTypeCar model;
        private Array modelType = Enum.GetValues(typeof(ModelTypeCar));
        private Array carType = Enum.GetValues(typeof(MakerType));
        private ICommand createCommand;
        private double price;
        private string color;
        private double year;
        private CarViewModel newcarViewModel;

        public AddCarViewModel(IEventAggregator eventAggregate)
        {
            CreateCommand = new DelegateCommand(OnCreateCar);
            this.eventAggregate = eventAggregate;

        }

        private void OnCreateCar()
        {
            NewcarViewModel = new CarViewModel(new DataAccessLayer.Models.Car(Make, Model, Year, Color, Price));
            eventAggregate.GetEvent<CatalogEvent>().Publish(new CatalogEventModel()
            {
                Sender = "AddCar",
                Car = NewcarViewModel
            });
        }


        public CarViewModel NewcarViewModel { get => newcarViewModel; set => SetProperty(ref newcarViewModel, value); }

        public string Title { get; set; } = "Create Car";
        public MakerType Make { get => make; set => SetProperty(ref make, value); }
        public ModelTypeCar Model { get => model; set => SetProperty(ref model, value); }
        public double Year { get => year; set => SetProperty(ref year, value); }
        public string Color { get => color; set => SetProperty(ref color, value); }
        public double Price { get => price; set => SetProperty(ref price, value); }

        public Array CarType
        {
            get => carType;
            set
            {
                SetProperty(ref carType, value);
            }
        }
        public Array ModelType
        {
            get => modelType;

            set => SetProperty(ref modelType, value);
        }
        public ICommand CreateCommand { get => createCommand; set => SetProperty(ref createCommand, value); }

     
    }
}
