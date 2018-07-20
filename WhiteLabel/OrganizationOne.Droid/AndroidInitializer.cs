using OrganizationOne.Core;
using Prism;
using Prism.Ioc;

namespace OrganizationOne.Droid
{
    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<MainPageDetail>();
            containerRegistry.RegisterForNavigation<MainPageMaster>();
        }
    }
}