using CatalogModul;
using CatalogModul.Implimentations;
using DataAccessLayer.Interfaces;
using OrderModul;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfVehicleApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainWindow, MainViewModel>();
            containerRegistry.Register<IRepository, Repository>();
            containerRegistry.RegisterForNavigation<CatalogModul.Views.AddCarView, CatalogModul.ViewModels.AddCarViewModel>("AddCarView");
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule(typeof(CatalogModule),InitializationMode.WhenAvailable);
            moduleCatalog.AddModule(typeof(OrderModule), InitializationMode.WhenAvailable);
        }
    }
}
