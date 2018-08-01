using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinApp2.DataAccess
{
    //[Table("Recipes")] --nazwa tabeli
    public class Recipe : INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        private string _name;
        [MaxLength(255)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value)
                    return;

                _name = value;

                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SQLitePage : ContentPage
	{
        private SQLiteAsyncConnection _conncetion;
        private ObservableCollection<Recipe> _recipes;

		public SQLitePage ()
		{
			InitializeComponent ();

            _conncetion = DependencyService.Get<ISQLiteDb>().GetConnection();

		}

        protected override async void OnAppearing()
        {
            await _conncetion.CreateTableAsync<Recipe>();

            var recipes = await _conncetion.Table<Recipe>().ToListAsync();
            _recipes = new ObservableCollection<Recipe>(recipes);
            recipesListView.ItemsSource = _recipes;

            base.OnAppearing();
        }

        async void OnAdd(object sender, EventArgs e)
        {
            var recipe = new Recipe { Name = "Recipe " + DateTime.Now.Ticks };
            await _conncetion.InsertAsync(recipe);

            _recipes.Add(recipe);
        }

        async void OnUpdate(object sender, EventArgs e)
        {
            var recipe = _recipes[0];
            recipe.Name += " Updated";

            await _conncetion.UpdateAsync(recipe);
        }

        async void OnDelete(object sender, EventArgs e)
        {
            var recipe = _recipes[0];

            await _conncetion.DeleteAsync(recipe);

            _recipes.Remove(recipe);
        }
    }
}