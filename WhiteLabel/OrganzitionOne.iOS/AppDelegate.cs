using AppBase.iOS;
using Foundation;
using OrganizationOne.Core;

namespace OrganzitionOne.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : AppDelegateBase
    {
        public override AppBase.Core.ApplicationBase LoadCustomApplication()
        {
            return new App(new iOSInitializer());
        }
    }
}
