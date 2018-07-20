using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp2.FormsAndSettings
{
    public class ContactMethod
    {
        public int Id { get; set; }
        public  string Name { get; set; }
    }

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerPage : ContentPage
	{
        private IList<ContactMethod> _contactMethods;

		public PickerPage ()
		{
			InitializeComponent ();

            _contactMethods = GetContactMethods();
            //var picker = new Picker { Title = "Phone" };
            foreach (var method in _contactMethods)
                contactMethods.Items.Add(method.Name);

        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name =  contactMethods.Items[contactMethods.SelectedIndex];
            var contactMethod = _contactMethods.Single(cm => cm.Name == name);
            DisplayAlert("Selection", name, "OK");
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod { Id = 1, Name = "Sms"},
                new ContactMethod { Id = 1, Name = "Phonw"}
            };
        }
    }
}