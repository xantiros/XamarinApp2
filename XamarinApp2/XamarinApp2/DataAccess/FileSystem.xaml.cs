using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp2.Interfaces;

namespace XamarinApp2.DataAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FileSystem : ContentPage
	{
		public FileSystem ()
		{
			InitializeComponent ();

            var fileSystem = DependencyService.Get<IFileSystem>();
            //fileSystem.WriteTextAsync();
		}
	}
}