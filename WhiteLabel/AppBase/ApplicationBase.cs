using Xamarin.Forms;
using Prism;
using Prism.Ioc;
using Prism.Unity;

namespace AppBase.Core
{
    public class ApplicationBase : PrismApplicationBase
    {
        public ApplicationBase() : this(null) { }
        public ApplicationBase(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
        }

        protected override IContainerExtension CreateContainerExtension()
        {
            return new UnityContainerExtension();
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