using Android.OS;
using AppBase.Core;
using Prism;

namespace AppBase.Droid
{
    public abstract class MainActivityBase : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(LoadCustomApplication());
        }

        public abstract ApplicationBase LoadCustomApplication();
    }
}
