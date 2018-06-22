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
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();

            slider.Value = 0.5;

            //Padding = new Thickness(20, 20, 20, 20);

            if (Device.RuntimePlatform == Device.iOS) // w przypadku ios ustawiamy od góry padding
                Padding = new Thickness(0, 20, 0, 0);

            switch(Device.RuntimePlatform) //to samo
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                    Padding = new Thickness(0, 0, 0, 0);
                    break;
            }
            Device.OnPlatform(
                iOS: () =>
                {
                    Padding = new Thickness(0, 20, 0, 0);
                }
                );


            /*
            Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Hello Darknes My old friend."

            };
            */
		}

        //private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    label.Text = String.Format("Value is {0:F2}", e.NewValue);
        //}
    }
}