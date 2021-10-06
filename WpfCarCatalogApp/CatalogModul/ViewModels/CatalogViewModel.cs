using CatalogModul.Implimentations;
using CatalogModul.Views;
using DataAccessLayer.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using System.Windows.Input;
using WpfShered.EventModels;
using WpfShered.Events;
using WpfShered.Utility;

namespace CatalogModul.ViewModels
{
    public class CatalogViewModel : BindableBase
    {

        public CatalogViewModel(IEventAggregator eventAggregator, IRegionManager regionManager, IRepository _repository)
        {
            this.repository = _repository /*new Repository()*/;
            var cars1 = repository.GetCars().Select(e => new CarViewModel(e)).ToList();
            Cars = new ObservableCollection<CarViewModel>(cars1);
            CarView = new CollectionViewSource { Source = Cars }.View;
            CarView.Filter = car =>
            {
                var item = (CarViewModel)car;
                var result = SelectedModel == item.Model && SelctedItemMaker == item.Make ? true
                : (SelctedItemMaker == default && SelectedModel == default ? true
                : (SelctedItemMaker == item.Make && SelectedModel == default ? true
                : (SelctedItemMaker == default && SelectedModel == item.Model ? true : false)));
                return result;
            };

            this.eventAggregator = eventAggregator;
            this.regionManager = regionManager;
            SendOrderCommand = new DelegateCommand<CarViewModel>(OnSenderCar);
            AddCarCommand = new DelegateCommand<CarViewModel>(OnAddCar);
            eventAggregator.GetEvent<CatalogEvent>().Subscribe(OnGetNewCar);
        }

        private void OnGetNewCar(CatalogEventModel obj)
        {
            if (obj.Sender.Equals("AddCar"))
            {

                var car = (CarViewModel)obj.Car;
                Cars.Add(car);
            }
        }

        private readonly IRepository repository;
        private readonly IEventAggregator eventAggregator;
        private readonly IRegionManager regionManager;
        private CarViewModel selectedCar;
        private ObservableCollection<CarViewModel> cars;

        private ICommand sendOrderCommand;
        private MakerType selctedItemMaker = default(MakerType);
        private ICollectionView carView;
        private ModelTypeCar selectedModel = default(ModelTypeCar);
        private ICommand addCarCommand;
        private Array modelType = Enum.GetValues(typeof(ModelTypeCar));

        public ICollectionView CarView { get => carView; set => SetProperty(ref carView, value); }
        public string Title { get; set; } = "Catalog";
        public Array CarType { get; set; } = Enum.GetValues(typeof(MakerType));
        public Array ModelType
        {
            get => modelType;
            set
            {

                SetProperty(ref modelType, value);
            }
        }

        public CarViewModel SelectedCar { get => selectedCar; set => SetProperty(ref selectedCar, value); }



        public ModelTypeCar SelectedModel
        {
            get => selectedModel;

            set
            {
                SetProperty(ref selectedModel, value);

                CarView.Refresh();
            }
        }
        public MakerType SelctedItemMaker
        {
            get => selctedItemMaker;
            set
            {
                SetProperty(ref selctedItemMaker, value);
                ModelType = SelctedItemMaker == default ? Enum.GetValues(typeof(ModelTypeCar)) : Cars.Where(e => e.Make == SelctedItemMaker).Select(e => e.Model).ToArray();
                RaisePropertyChanged("SelectedModel");
                CarView.Refresh();
            }
        }

        public ObservableCollection<CarViewModel> Cars
        {
            get => cars;
            set => SetProperty(ref cars, value);
        }
        public ICommand SendOrderCommand { get => sendOrderCommand; set { SetProperty(ref sendOrderCommand, value); } }
        public ICommand AddCarCommand { get => addCarCommand; set => SetProperty(ref addCarCommand, value); }

        private void OnSenderCar(CarViewModel obj)
        {
            eventAggregator.GetEvent<CatalogEvent>().Publish(new CatalogEventModel() { Sender = "Catalog", Car = SelectedCar });
            Cars.Remove(obj);
        }

        private void OnAddCar(CarViewModel obj)
        {
            regionManager.RequestNavigate("TabRegion", new Uri("AddCarView", UriKind.RelativeOrAbsolute));
        }
    }
}
