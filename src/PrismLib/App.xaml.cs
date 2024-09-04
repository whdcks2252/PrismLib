using PrismLib.Core;
using PrismLib.Modules.Module1;
using PrismLib.Modules.Module2;
using PrismLib.Views;
using System.Windows;

namespace PrismLib
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {

            var window = this.Container.Resolve<MainWindow>();

            window.Loaded += (sender, args) =>
            {
                var manager = this.Container.Resolve<IRegionManager>();

                manager.RequestNavigate(RegionNames.ContentRegion, Module1Name.Module1View);
            };

            return window;
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<MainWindow>();

        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Module1NameModule>();
            moduleCatalog.AddModule<Module2NameModule>();
        }
    }

}
