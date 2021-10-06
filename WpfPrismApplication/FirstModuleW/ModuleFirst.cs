using FirstModuleW.ViewModels;
using FirstModuleW.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstModuleW
{
    public class ModuleFirst : IModule
    {
        private readonly IRegionManager regionManager;

        public ModuleFirst(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewFirst, ViewModelsFirst>();
            regionManager.RegisterViewWithRegion<ViewFirst>("FirstRegion");
        }
    }
}
