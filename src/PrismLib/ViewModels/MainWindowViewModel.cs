using PrismLib.Core;
using PrismLib.Core.Mvvm;
using PrismLib.Modules.Module1;
using PrismLib.Modules.Module2;
using System.Windows.Input;

namespace PrismLib.ViewModels
{
    public class MainWindowViewModel : RegionViewModelBase
    {
        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ICommand SelectedModuleCommand { get; set; }

        private readonly IRegionManager _regionManager;
        public MainWindowViewModel(IRegionManager regionManager) :
            base(regionManager)
        {
            _regionManager = regionManager;
            SelectedModuleCommand = new DelegateCommand<string>(OnNavigate,(string o)=>true);
        }

        private void OnNavigate(string o)
        {
            if (o=="Module1")
            {
                _regionManager.RequestNavigate(RegionNames.ContentRegion, Module1Name.Module1View);
                return;
            }

            if (o == "Module2")
            {
                _regionManager.RequestNavigate(RegionNames.ContentRegion, Module2Name.Module2View);
                return;
            }
        }
    }
}
