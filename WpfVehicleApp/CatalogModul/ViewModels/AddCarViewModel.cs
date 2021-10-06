using CatalogModul.Views;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using WpfShered.Event;
using WpfShered.EventModel;

namespace CatalogModul.ViewModels
{
    public class AddCarViewModel : BindableBase
    {
       
        public AddCarViewModel(IEventAggregator eventAggregate, IRepository repositor,IRegionManager regionManager)
        {
            this.repositor = repositor;
            this.regionManager = regionManager;
            CarType = repositor.GetMakes();
            CreateCommand = new DelegateCommand(OnCreateCar);
            this.eventAggregate = eventAggregate;
        }

        private void OnCreateCar()
        {
            NewCar = new Car(Make, Model, Year, Color, Price);
            eventAggregate.GetEvent<CatalogEvent>().Publish(new CatalogEventModel()
            {
                Sender = "AddCar",
                Car = NewCar
            });
           
        }

        public Car NewCar { get => newcar; set => SetProperty(ref newcar, value); }
        public string Title { get; set; } = "Create Car";

        public Make Make
        {
            get => make;
            set => SetProperty(ref make, value);
        }
        public List<Model> ModelType
        {
            get => modelType;

            set => SetProperty(ref modelType, value);
        }
        public Model Model 
        { 
            get => model; 
            set => SetProperty(ref model, value); 
        }
        public int Year 
        { 
            get => year; 
            set => SetProperty(ref year, value); 
        }
        public string Color 
        {
            get => color; 
            set => SetProperty(ref color, value);
        }
        public double Price 
        { 
            get => price; 
            set => SetProperty(ref price, value); 
        }

        public List<Make> CarType
        {
            get => carType;
            set
            {
                SetProperty(ref carType, value);
            }
        }

        public ICommand CreateCommand 
        { 
            get => createCommand; 
            set => SetProperty(ref createCommand, value); 
        }

        private readonly IEventAggregator eventAggregate;
        private readonly IRepository repositor;
        private readonly IRegionManager regionManager;
        private Make make;
        private Model model;
        private List<Model> modelType;
        private List<Make> carType;
        private ICommand createCommand;
        private double price;
        private string color;
        private int year;
        private Car newcar;
    }
}
