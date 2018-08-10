using AppBase.Core;
using AppBase.Services;
using OrganizationOne.Core.ViewModel;
using OrganizationOne.Services;
using Prism;
using Prism.Ioc;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace OrganizationOne.Core
{
    public partial class App : ApplicationBase
    {
        public App() { InitializeComponent(); }
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            Resources.Add(new ResourceBase());

            base.OnInitialized();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterTypes(containerRegistry);

            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>("LoginPage");

            containerRegistry.RegisterSingleton<ILoginServiceBase, LoginService>();
        }
    }
}