using PrismLib.Modules.Module2.ViewModels;
using PrismLib.Modules.Module2.Views;

namespace PrismLib.Modules.Module2
{
    public class Module2NameModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public Module2NameModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Module2View>();

        }
    }
}
