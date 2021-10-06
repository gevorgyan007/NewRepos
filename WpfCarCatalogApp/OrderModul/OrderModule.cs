using OrderModul.View;
using OrderModul.ViewModels;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModul
{
    public class OrderModule : IModule
    {
        private readonly IRegionManager regionManager;

        public OrderModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        { 

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<OrderView, OrderViewModel>("Order");
           
            regionManager.RegisterViewWithRegion<OrderView>("TabRegion");
        }
    }
}
