using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp2.Lists;
using XamarinApp2.Navigation;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamarinApp2
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new ToolbarItemsPage());

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
	}
}
