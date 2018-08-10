using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrganizationTwo.Core
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResourceBase : ResourceDictionary
    {
		public ResourceBase ()
		{
			InitializeComponent ();
		}
	}
}