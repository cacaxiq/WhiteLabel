using Android.App;
using Android.Content.PM;
using AppBase.Droid;

namespace Organization.Droid.Droid
{
    [Activity(Label = "Organization.Droid", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MainActivityBase
    { }
}

