using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;

namespace AppBase.Core
{
    public class ApplicationBase : PrismApplication
    {
        public ApplicationBase() : this(null) { }
        public ApplicationBase(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}