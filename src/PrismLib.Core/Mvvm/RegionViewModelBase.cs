namespace PrismLib.Core.Mvvm
{
    public class RegionViewModelBase : ViewModelBase, INavigationAware, IConfirmNavigationRequest
    {
        protected IRegionManager RegionManager { get; private set; }

        public RegionViewModelBase(IRegionManager regionManager)
        {
            RegionManager = regionManager;
        }

        //이 메서드는 네비게이션이 발생하기 전에 호출됩니다. 여기서 continuationCallback은 네비게이션을 진행할지 여부를 결정하는 콜백 함수입니다.
        public virtual void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            // true를 전달하면 네비게이션을 계속 진행하고, false를 전달하면 네비게이션을 중단합니다.
            continuationCallback(true);
        }

        // 같은 뷰 모델 인스턴스를 재사용할 것인지 여부를 반환
        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            //만약 특정 조건 하에서 새로운 상태로 페이지를 로드하고 싶다면 false를 반환하여 새로운 ViewModel 인스턴스가 생성되도록 할 수 있습니다.
            return true;
        }

        // 네비게이션 전에서 실행할 코드
        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        // 네비게이션 후에 실행할 코드
        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {

        }
    }
}
