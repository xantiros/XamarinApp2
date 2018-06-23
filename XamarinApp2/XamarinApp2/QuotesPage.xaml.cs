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
	public partial class QuotesPage : ContentPage
	{
        private string[] quotes = { "Kocham Cię", "Moja Jedyna", "Myślę o Tobie" };
        private int i = 0;

        public QuotesPage ()
		{
			InitializeComponent ();

            Padding = new Thickness(20, 20, 20, 20);    
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            i++;
            if (i == quotes.Length) i = 0;
            label2.Text = quotes[i];
        }
    }
}