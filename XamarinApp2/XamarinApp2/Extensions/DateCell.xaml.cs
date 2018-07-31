using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp2.Extensions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DateCell : ViewCell
	{
        public static readonly BindableProperty labelProperty 
            = BindableProperty.Create("Label", typeof(string), typeof(DateCell));

        public string Label
        {
            get { return (string)GetValue(labelProperty); }
            set { SetValue(labelProperty, value); }
        }

        public DateCell ()
		{
			InitializeComponent ();

            BindingContext = this;
		}
	}
}