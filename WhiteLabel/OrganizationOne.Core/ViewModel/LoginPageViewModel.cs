using System;
using System.Threading.Tasks;
using AppBase.Core.ViewModel;
using AppBase.Services;
using OrganizationOne.Services.Model;
using Prism.Commands;
using Prism.Navigation;

namespace OrganizationOne.Core.ViewModel
{
    public class LoginPageViewModel : BaseViewModel
    {
        private readonly ILoginServiceBase loginService;

        #region Properties
        private string username;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        #endregion

        #region Commands
        private DelegateCommand _login;
        public DelegateCommand LoginCommand =>
            _login ?? (_login = new DelegateCommand(async () => { await ExecuteLoginCommand(); }, CanExecuteLoginCommand));

        async Task ExecuteLoginCommand()
        {
            var response = await loginService.ExecuteLogin(Username, Password);
            var access = response.Data as AccessToken;

            if (!access.Authenticated)
                Message = "Erro no login!!";
        }

        bool CanExecuteLoginCommand()
        {
            return !string.IsNullOrEmpty(Username) || !string.IsNullOrEmpty(Password);
        }
        #endregion

        public LoginPageViewModel(ILoginServiceBase loginService, INavigationService navigationService) : base(navigationService)
        {
            this.loginService = loginService;
        }

    }
}

