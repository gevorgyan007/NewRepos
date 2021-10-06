using CatalogModul.ViewModels;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfShered.EventModels;
using WpfShered.Events;

namespace OrderModul.ViewModels
{
    public class OrderViewModel : BindableBase
    {
        private ObservableCollection<CarViewModel> orders;
        private readonly IEventAggregator eventAggregate;

        public string Title { get; set; } = "Order";

        public ObservableCollection<CarViewModel> Orders { get => orders; set => SetProperty(ref orders , value); }

        public OrderViewModel(IEventAggregator eventAggregate)
        {
            Orders = new ObservableCollection<CarViewModel>();
            this.eventAggregate = eventAggregate;
            this.eventAggregate.GetEvent<CatalogEvent>().Subscribe(OnGetCar);
        }

        private void OnGetCar(CatalogEventModel obj)
        {
            var car = (CarViewModel)(obj.Car);
            Orders.Add(car);
        }
    }
}
