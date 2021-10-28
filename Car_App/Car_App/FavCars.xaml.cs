using Car_App.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Car_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavCars : ContentPage
    {
        FavCarsModel FavCarList = new FavCarsModel();
        public FavCars()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<FavCarsModel>();
            var cars = conn.Table<FavCarsModel>().ToList();
            CarsListView.ItemsSource = cars;
            conn.Close();
        }

        private void OnTappedItem(object sender, ItemTappedEventArgs e)
        {

        }
    }
   
}