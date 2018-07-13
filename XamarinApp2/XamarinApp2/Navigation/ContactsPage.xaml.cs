using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp2.Models;

namespace XamarinApp2.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
		public ContactsPage ()
		{
			InitializeComponent ();

            listView.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Ben", ImageUrl = "https://source.unsplash.com/collection/368775/100x100" },
                new Contact {Name = "Bob", ImageUrl = "https://source.unsplash.com/collection/368775/100x100", Status = "Hey, let's talk." },
                new Contact {Name = "Johon", ImageUrl = "https://source.unsplash.com/collection/368775/100x100", Status = "2." }
            };
        }

        async private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return; 
            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));
            listView.SelectedItem = null;
        }
    }
}