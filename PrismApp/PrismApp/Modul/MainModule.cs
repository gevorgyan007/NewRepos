using FirstProj;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SecondProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modul
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("MainRegion", typeof(UserControl1));
            region.RegisterViewWithRegion("SecondRegion", typeof(UserControl2));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
          
        }
    }
}
