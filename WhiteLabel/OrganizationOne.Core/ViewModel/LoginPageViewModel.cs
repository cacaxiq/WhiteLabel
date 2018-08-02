using AppBase.Core.ViewModel;
using AppBase.Services;
using Prism.Commands;
using Prism.Navigation;

namespace OrganizationOne.Core.ViewModel
{
    public class LoginPageViewModel : BaseViewModel
    {
        private readonly ILoginServiceBase loginService;

        DelegateCommand LoginCommand;

        public LoginPageViewModel(ILoginServiceBase loginService, INavigationService navigationService) :  base(navigationService)
        {
            this.loginService = loginService;


        }

    }
}

