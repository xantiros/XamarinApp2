using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp2.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DisplayingPopupsPage : ContentPage
	{
		public DisplayingPopupsPage ()
		{
			InitializeComponent ();
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Email");
            await DisplayAlert("Response", response, "Ok");

            //var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");

            //if (response)
            //    DisplayAlert("Done", "Your response will be saved!", "OK");
        }
    }
}