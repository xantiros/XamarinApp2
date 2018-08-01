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

            BindingContext = Application.Current;

            //var app = Application.Current as App;
            //app.Title = title.Text;
            //app.NotificationsEnabled = notificationsEnabled.On;

            //if (Application.Current.Properties.ContainsKey(TitleKey))
            //title.Text = Application.Current.Properties[TitleKey].ToString();

            //if (Application.Current.Properties.ContainsKey(NotificationsEnabledKey))
            //    notificationsEnabled.On = (bool)Application.Current.Properties[NotificationsEnabledKey];

		}

        //private void OnChange(object sender, EventArgs e)
        //{
        //    var app = Application.Current as App;
        //    app.Title = title.Text;
        //    app.NotificationsEnabled = notificationsEnabled.On;

        //    //Application.Current.SavePropertiesAsync();
        //}

        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //}
    }
}