using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Contact> _contacts;

		public ListViews ()
		{
			InitializeComponent ();

            _contacts = new ObservableCollection<Contact>
            {
                new Contact {Name = "Ben", ImageUrl = "https://source.unsplash.com/collection/368775/100x100" },
                new Contact {Name = "Bob", ImageUrl = "https://source.unsplash.com/collection/368775/100x100", Status = "Hey, let's talk." }
            };

            listViews.ItemsSource = _contacts;

            //listViews.ItemsSource = new List<ContactGroup>
            //{
            //    new ContactGroup("B", "B")
            //    {
            //        new Contact {Name = "Ben", ImageUrl = "https://source.unsplash.com/collection/368775/100x100" },
            //        new Contact {Name = "Bob", ImageUrl = "https://source.unsplash.com/collection/368775/100x100", Status = "Hey, let's talk." }
            //    },
            //    new ContactGroup("J", "J")
            //    {
            //        new Contact {Name = "John", ImageUrl = "https://source.unsplash.com/collection/368775/100x100", Status = "1"}
            //    }            
            //};

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

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }
        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        private void listViews_Refreshing(object sender, EventArgs e)
        {
            listViews.ItemsSource = GetContacts();
            listViews.IsRefreshing = false;
        }

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts =  new List<Contact>
            {
                new Contact {Name = "Ben", ImageUrl = "https://source.unsplash.com/collection/368775/100x100" },
                new Contact {Name = "Bob", ImageUrl = "https://source.unsplash.com/collection/368775/100x100", Status = "Hey, let's talk." },
                new Contact {Name = "Johon", ImageUrl = "https://source.unsplash.com/collection/368775/100x100", Status = "2." }
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c => c.Name.StartsWith(searchText));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listViews.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}