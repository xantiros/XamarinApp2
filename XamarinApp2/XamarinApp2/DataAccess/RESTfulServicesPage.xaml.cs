using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp2.DataAccess
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RESTfulServicesPage : ContentPage
	{
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Post> _post;

		public RESTfulServicesPage ()
		{
			InitializeComponent ();
		}
        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync(Url);
            //deserializacja
            var post = JsonConvert.DeserializeObject<List<Post>>(content);

            _post = new ObservableCollection<Post>(post);
            postsListView.ItemsSource = _post;

            base.OnAppearing();
        }

        async void OnAdd(object sender, EventArgs e)
        {
            var post = new Post { Title = "Title " + DateTime.Now.Ticks };

            _post.Insert(0, post);

            var content = JsonConvert.SerializeObject(post);
            await _client.PostAsync(Url, new StringContent(content));

        }

        async void OnUpdate(object sender, EventArgs e)
        {
            var post = _post[0];
            post.Title += " UPDATED";

            var content = JsonConvert.SerializeObject(post);
            await _client.PutAsync(Url + "/" + post.Id, new StringContent(content));
        }

        async void OnDelete(object sender, EventArgs e)
        {
            var post = _post[0];

            _post.Remove(post);

            await _client.DeleteAsync(Url + "/" + post.Id);
        }
    }
}