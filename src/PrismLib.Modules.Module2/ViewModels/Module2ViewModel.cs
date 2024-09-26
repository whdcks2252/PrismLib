using PrismLib.Core.Mvvm;
using System.Diagnostics;
using System.Windows.Input;
using UsingEventAggregator.Core;

namespace PrismLib.Modules.Module2.ViewModels
{
    public class Module2ViewModel : RegionViewModelBase
    {
        private string _bt = "Prism Unity Application";
        public string Bt
        {
            get { return _bt; }
            set { SetProperty(ref _bt, value); }
        }

        public ICommand Module2Command => new DelegateCommand(OnModule, () => true);

        private readonly IEventAggregator _ea;
        public Module2ViewModel(IRegionManager regionManager, IEventAggregator ea) :
            base(regionManager)
        {
            _ea = ea;
            Debug.WriteLine("module2");

        }
        private void OnModule()
        {
            _ea.GetEvent<MessageSentEvent>().Publish("SetModule2");

        }
      
    }
}
