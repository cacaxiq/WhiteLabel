using AppBase.Core;
using OrganizationOne.Core.ViewModel;
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

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterTypes(containerRegistry);

            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>("LoginPage");
        }
    }
}