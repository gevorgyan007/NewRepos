using CatalogModul.ViewModels;
using CatalogModul.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogModul
{
    public class CatalogModule : IModule
    {
        private readonly IRegionManager regionManager;

        public CatalogModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
           
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CatalogView, CatalogViewModel>("Catalog");
            containerRegistry.RegisterForNavigation<AddCarView, AddCarViewModel>("AddCarView");
            regionManager.RegisterViewWithRegion<CatalogView>("TabRegion");
            //regionManager.RegisterViewWithRegion<AddCarView>("TabRegion");
        }
    }
}
