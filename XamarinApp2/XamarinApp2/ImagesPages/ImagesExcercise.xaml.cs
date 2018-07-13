using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagesExcercise : ContentPage
	{
        private int _currentImageId = 1;

		public ImagesExcercise ()
		{
			InitializeComponent ();

            _currentImageId = 1;

            LoadImage();
		}

        void LoadImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("https://source.unsplash.com/1920x1280?city?{0}", _currentImageId)),
                CachingEnabled = false
            };
        }

        void Previous_Clicked(object sender, EventArgs e)
        {
            _currentImageId--;
            if (_currentImageId == 0)
                _currentImageId = 10;

            LoadImage();
        }

        void Next_Clicked(object sender, EventArgs e)
        {
            _currentImageId++;
            if (_currentImageId == 11)
                _currentImageId = 1;

            LoadImage();
        }
	}
}