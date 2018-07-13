using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp2.Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViews : ContentPage
	{
		public ListViews ()
		{
			InitializeComponent ();

        var names = new List<string>
        {
            "Ben",
            "John",
            "Bob"
        };

            listViews.ItemsSource = names;

        }
    }
}