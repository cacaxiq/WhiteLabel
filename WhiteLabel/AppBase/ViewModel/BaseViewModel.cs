using Prism.Mvvm;
using Prism.Navigation;

namespace AppBase.Core.ViewModel
{
    public abstract class BaseViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService navigationService;

        public BaseViewModel(INavigationService navigationService = null)
        {
            this.navigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }

        public virtual void OnNavigatedTo(INavigationParameters parameters) { }

        public virtual void OnNavigatingTo(INavigationParameters parameters) { }
    }
}
