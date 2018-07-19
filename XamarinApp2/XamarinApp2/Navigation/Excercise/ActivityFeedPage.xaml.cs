using Xamarin.Forms;
using XamarinApp2.Navigation.Models;

namespace XamarinApp2.Navigation
{
    public partial class ActivityFeedPage : ContentPage
    {
        private ActivityService _service = new ActivityService();

        public ActivityFeedPage()
        {
            InitializeComponent();

            activityFeed.ItemsSource = _service.GetActivities();
        }

        void OnActivitySelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var activity = e.SelectedItem as Activity;

            activityFeed.SelectedItem = null;

            Navigation.PushAsync(new UserProfilePage(activity.UserId));
        }
    }
}
