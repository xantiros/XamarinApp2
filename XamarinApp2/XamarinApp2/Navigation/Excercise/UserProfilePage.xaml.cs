using Xamarin.Forms;

namespace XamarinApp2.Navigation
{
    public partial class UserProfilePage : ContentPage
    {
        private UserService _service = new UserService();

        public UserProfilePage(int userId)
        {
            BindingContext = _service.GetUser(userId);

            InitializeComponent();
        }
    }
}