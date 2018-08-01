using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp2.DataAccess;
using XamarinApp2.FormsAndSettings;
using XamarinApp2.Lists;
using XamarinApp2.Navigation;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamarinApp2
{
	public partial class App : Application
	{
        private const string TitleKey = "Name";
        private const string NotificationsEnabledKey = "NotificationsEnabled";

        public App ()
		{
			InitializeComponent();

            MainPage = new ApplicationPropertiesPage();

			//MainPage = new NavigationPage (new WelcomePage())
   //         {
   //             BarBackgroundColor = Color.Gray,
   //             BarTextColor = Color.White
            //};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();
                return "";
            }
            set
            {
                Properties[TitleKey] = value;
            }
        }

        public bool NotificationsEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationsEnabledKey))
                    return (bool)Properties[NotificationsEnabledKey];
                return false;
            }
            set
            {
                Properties[NotificationsEnabledKey] = value;
            }
        }

	}
}
