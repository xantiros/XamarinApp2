using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            //var imageSource = (UriImageSource) ImageSource.FromUri(new Uri("https://picsum.photos/1920/1080/?random/"));

            //var imageSource = new UriImageSource { Uri = new Uri("https://picsum.photos/1920/1080/?random/") };
            //imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);
            //image.Source = imageSource;
            //image.Source = ImageSource.FromResource("XamarinApp2.Images.background.jpg");

        }
	}
}