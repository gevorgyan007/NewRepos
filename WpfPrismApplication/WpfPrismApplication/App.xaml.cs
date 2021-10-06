using FirstModuleW;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using SecondModuleW;
using System.Windows;

namespace WpfPrismApplication
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
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule(typeof(ModuleFirst));
            moduleCatalog.AddModule(typeof(ModuleSecond));
        }
    }
}
