using Android.App;
using Android.Content.PM;
using Android.OS;
using AppBase.Droid;
using OrganizationOne.Core;

namespace OrganizationOne.Droid
{
    [Activity(Label = "Organization.Droid", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MainActivityBase
    {
        public override AppBase.Core.ApplicationBase LoadCustomApplication()
        {
            return new App(new OrganizationOne.Droid.AndroidInitializer());
        }

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(new OrganizationOne.Droid.AndroidInitializer()));
        }
    }
}

