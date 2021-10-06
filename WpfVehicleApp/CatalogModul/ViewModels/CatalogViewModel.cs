using CatalogModul.Views;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using System.Windows.Input;
using WpfShered.Event;
using WpfShered.EventModel;

namespace CatalogModul.ViewModels
{
    public class CatalogViewModel : BindableBase
    {

        public CatalogViewModel(IRepository repasitory, IEventAggregator eventAggregate, IRegionManager regionManager)
        {
            this.repasitory = repasitory;
            this.eventAggregate = eventAggregate;
            this.regionManager = regionManager;
            allCar = repasitory.GetCars();
            Cars = new ObservableCollection<Car>(allCar);
            Makes = repasitory.GetMakes();
            SendOrderCommand = new DelegateCommand<Car>(OnSenderCar);
            eventAggregate.GetEvent<CatalogEvent>().Subscribe(OnGetNewCar);
            AddCarCommand = new DelegateCommand<Car>(OnAddCar, (c)=>true);
            RemoveCammand = new DelegateCommand<Car>(OnRemove);
        }

        public Model SelectedModel
        {
            
            get => selectedModel;
            set
            {
                SetProperty(ref selectedModel, value, OnSelectedModelChanged, nameof(SelectedModel));
            }
        }

        public Make SelctedMaker
        {
            get => selctedMaker;
            set => SetProperty(ref selctedMaker, value, OnSelctedMakerChanged, nameof(SelctedMaker));
        }

        public ObservableCollection<Car> Cars
        {
            get => cars;
            set => SetProperty(ref cars, value);
        }

        public List<Make> Makes
        {
            get => makes;
            set => SetProperty(ref makes, value);
        }

        public Car SelectedCar
        {
            get => selectedCar;
            set => SetProperty(ref selectedCar, value);
        }
        public ICommand SendOrderCommand
        {
            get => sendOrderCommand;
            set { SetProperty(ref sendOrderCommand, value); }
        }
        public ICommand AddCarCommand
        {
            get => addCarCommand;
            set => SetProperty(ref addCarCommand, value);
        }
        public ICommand RemoveCammand
        {
            get ;
            set ;
        }

        private void OnSelectedModelChanged()
        {

            if (selectedModel != null)
            {
                Cars.Clear();
                Cars.AddRange(GetCars(selectedModel));
            }

        }
        public string Title { get; set; } = "Catalog";


        private void OnSenderCar(Car obj)
        {
            eventAggregate.GetEvent<CatalogEvent>().Publish(new CatalogEventModel() { Sender = "Catalog", Car = SelectedCar });
            Cars.Remove(obj);
        }

        private void OnGetNewCar(CatalogEventModel obj)
        {
            if (obj.Sender.Equals("AddCar"))
            {
                var car = (Car)obj.Car;
                Cars.Add(car);
            }
        }

        private void OnAddCar(Car obj)
        {
            regionManager.RequestNavigate("TabRegion", new Uri("AddCarView", UriKind.RelativeOrAbsolute));
        }

        private void OnRemove(Car obj)
        {
            Cars.Remove(obj);
        }

        public IEnumerable<Car> GetCars(Model filter)
        {
            return allCar.Where(c => c.Models.Name.Equals(filter.Name));
        }

        public IEnumerable<Car> GetCars(Make filter)
        {
            return allCar.Where(c => c.Makes.Name.Equals(filter.Name));
        }

        private void OnSelctedMakerChanged()
        {
            Cars.Clear();
            if (selctedMaker != null)
                Cars.AddRange(GetCars(selctedMaker));
        }

        private IRepository repasitory;
        private readonly IEventAggregator eventAggregate;
        private readonly IRegionManager regionManager;
        private Car selectedCar;
        private ObservableCollection<Car> cars;
        private Model selectedModel;
        private Make selctedMaker;
        private ICommand sendOrderCommand;
        private ICommand addCarCommand;
        private List<Car> allCar;
        private List<Make> makes;
    }
}
