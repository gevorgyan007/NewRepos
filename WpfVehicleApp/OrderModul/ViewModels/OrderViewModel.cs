using CatalogModul.ViewModels;
using DataAccessLayer.Models;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfShered.Event;
using WpfShered.EventModel;

namespace OrderModul.ViewModels
{
    public class OrderViewModel : BindableBase
    {
      
        public string Title { get; set; } = "Order";

        public ObservableCollection<Car> Orders { get => orders; set => SetProperty(ref orders, value); }

        public OrderViewModel(IEventAggregator eventAggregate)
        {
            Orders = new ObservableCollection<Car>();
            this.eventAggregate = eventAggregate;
            this.eventAggregate.GetEvent<CatalogEvent>().Subscribe(OnGetCar);
        }

        private void OnGetCar(CatalogEventModel obj)
        {
            var car = (Car)obj.Car;
            Orders.Add(car);
        }

        private ObservableCollection<Car> orders;
        private readonly IEventAggregator eventAggregate;

    }
}
