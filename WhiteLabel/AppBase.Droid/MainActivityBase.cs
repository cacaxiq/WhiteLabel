using Android.OS;
using AppBase.Core;
using Prism;

namespace AppBase.Droid
{
    public abstract class MainActivityBase : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public abstract ApplicationBase LoadCustomApplication();
    }
}
