using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp2.DataAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApplicationPropertiesPage : ContentPage
	{
		public ApplicationPropertiesPage ()
		{
			InitializeComponent ();

            if(Application.Current.Properties.ContainsKey("Name"))
            title.Text = Application.Current.Properties["Name"].ToString();

            if (Application.Current.Properties.ContainsKey("NotificationsEnabled"))
                notificationsEnabled.On = (bool)Application.Current.Properties["NotificationsEnabled"];

		}

        private void OnChange(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = title.Text;
            Application.Current.Properties["NotificationsEnabled"] = notificationsEnabled;

            //Application.Current.SavePropertiesAsync();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}