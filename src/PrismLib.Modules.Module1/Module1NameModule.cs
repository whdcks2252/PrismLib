using PrismLib.Modules.Module1.Views;
using System.Diagnostics;

namespace PrismLib.Modules.Module1
{
    public class Module1NameModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public Module1NameModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Module1View>();
        }
    }
}
