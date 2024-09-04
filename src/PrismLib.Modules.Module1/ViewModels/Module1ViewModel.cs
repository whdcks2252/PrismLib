using PrismLib.Core.Mvvm;
using System.Diagnostics;
using System.Windows.Input;
using UsingEventAggregator.Core;

namespace PrismLib.Modules.Module1.ViewModels
{
    public class Module1ViewModel : RegionViewModelBase
    {
        private string _bt = "Prism Unity Application";
        public string Bt
        {
            get { return _bt; }
            set { SetProperty(ref _bt, value); }
        }
        public ICommand Module1Command { get; set; }

        private readonly IEventAggregator _ea;
        public Module1ViewModel(IRegionManager regionManager, IEventAggregator ea) :
            base(regionManager)
        {
            _ea= ea;
            Module1Command = new DelegateCommand(OnModule, () => true);
            _ea.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);

        }
        private void OnModule()
        {

        }
        private void MessageReceived(string message)
        {
           Debug.WriteLine(message);
        }
    }
}
