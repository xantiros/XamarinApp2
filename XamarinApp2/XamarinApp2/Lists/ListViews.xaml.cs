using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp2.Models;

namespace XamarinApp2.Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViews : ContentPage
	{
		public ListViews ()
		{
			InitializeComponent ();

            listViews.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("B", "B")
                {
                    new Contact {Name = "Ben", ImageUrl = "https://source.unsplash.com/collection/368775/100x100" },
                    new Contact {Name = "Bob", ImageUrl = "https://source.unsplash.com/collection/368775/100x100", Status = "Hey, let's talk." }
                },
                new ContactGroup("J", "J")
                {
                    new Contact {Name = "John", ImageUrl = "https://source.unsplash.com/collection/368775/100x100", Status = "1"}
                }            
            };

        }

        private void listViews_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void listViews_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listViews.SelectedItem = null;
            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");
        }
    }
}