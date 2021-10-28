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
    public partial class CarDetails : ContentPage
    {
        public string carImg = string.Empty;
        public int ID;
        public bool fav;

        public CarDetails(int Id,string image, string name, string detail, string year, string color, string driven, string avearage,string fuelmode)
        {
            InitializeComponent();
            FavBtn.Text = "Add to Favorite";
            FavBtn.BackgroundColor = Color.Pink;
            fav = false;


            carimage.Source = new UriImageSource()
            {
                Uri = new Uri(image)
            };
            carImg = image;
            carname.Text = name;
            cardetail.Text = detail;
            caryear.Text = year;
            carcolor.Text = color;
            cardriven.Text = driven;
            caraverage.Text = avearage;
            carfuelmode.Text = fuelmode;
           

        }

        private void FavOnClick(object sender, EventArgs e)
        {

            FavCarsModel favCars = new FavCarsModel()
            {
                CarName = carname.Text,
                CarColor = carcolor.Text,
                DrivenKM = cardriven.Text,
                Average = caraverage.Text,
                CarYear = caryear.Text,
                FuelMode = carfuelmode.Text,
                Details = cardetail.Text,
                Image = carImg,

                };
                SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
                conn.CreateTable<FavCarsModel>();
                int rows = conn.Insert(favCars);
                conn.Close();
                // var cars = conn.Table<CarModel>().ToList();
                if (rows > 0)
                {
                    fav = true;
                    FavBtn.Text = "Added to Favorite";
                    FavBtn.BackgroundColor = Color.DeepPink;
                    DisplayAlert(carname.Text, "Added to Favorite", "Ok");
                }
                else
                {
                    fav = false;
                    FavBtn.Text = "Add to Favorite";
                    FavBtn.BackgroundColor = Color.Pink;
                    DisplayAlert(carname.Text, "Not Added to Favorite", "Ok");
                }
            
        }

            
            
    }
}