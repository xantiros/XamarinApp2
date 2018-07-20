using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp2.FormsAndSettings
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DateAndTimePickerPage : ContentPage
	{
		public DateAndTimePickerPage ()
		{
			InitializeComponent ();
		}

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            
        }
    }
}