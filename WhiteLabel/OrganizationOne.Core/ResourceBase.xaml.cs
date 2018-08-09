using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrganizationOne.Core
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