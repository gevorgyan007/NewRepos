using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SecondModuleW.ViewModels;
using SecondModuleW.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModuleW
{
    public class ModuleSecond : IModule
    {
        private readonly IRegionManager regionManager;

        public ModuleSecond(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<SecondView, SecondViewModel>();
            regionManager.RegisterViewWithRegion<SecondView>("SecondRegion");
        }
    }
}
