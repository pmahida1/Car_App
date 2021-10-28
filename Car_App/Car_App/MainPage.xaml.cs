using Car_App.Model;
using Car_App.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Car_App
{
    public partial class MainPage : ContentPage
    {
        /*public List<Data> cars_Data = new List<Data>()
        {
            new Data{Name = "Corolla", Comapny= "TOYOTA", Image = "corolla.jpeg" },
            new Data{Name = "Mirai", Comapny= "TOYOTA", Image = "mirai.jpeg"},
            new Data{Name = "Supra", Comapny= "TOYOTA", Image = "suprac.jpeg" },
            new Data{Name = "Maruti Gypsy", Comapny= "SUZUKI", Image = "marutijypsy.jpg" },
            new Data{Name = "Accent", Comapny= "HYUNDAI", Image = "accent.jpeg" },
            new Data{Name = "Elantra", Comapny= "HYUNDAI", Image = "elantra.jpeg" },
            new Data{Name = "Kona", Comapny= "HYUNDAI", Image = "kona.jpeg" },
            new Data{Name = "E-Pace", Comapny= "JAGUAR", Image = "epace.jpeg" },
            new Data{Name = "F-Type", Comapny= "JAGUAR", Image = "ftype.jpeg" },
            new Data{Name = "XE", Comapny= "JAGUAR", Image = "xe.jpeg" },
            new Data{Name = "A5", Comapny= "AUDI", Image = "a5.jpeg" },
            new Data{Name = "E-Tron", Comapny= "AUDI", Image = "etron.jpeg" },
            new Data{Name = "Huraca", Comapny= "LAMBORGHINI" , Image = "huracan.jpeg"},
            new Data{Name = "Sian", Comapny= "LAMBORGHINI", Image = "sian.jpeg" },
            new Data{Name = "Urus", Comapny= "LAMBORGHINI", Image = "urus.jpeg" }
        };*/
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new CarListViewModel();
            
           // cars_List.ItemsSource = cars_Data;
        }
        
        public async void OnTappedItem(object sender, ItemTappedEventArgs e)
        {
            var listDetails = e.Item as CarModel;
            var count = 1;
            listDetails.Id = count++;
            
            await Navigation.PushAsync(new CarDetails(listDetails.Id,listDetails.Image, listDetails.CarName, listDetails.Details, listDetails.CarYear, listDetails.CarColor,listDetails.DrivenKM,listDetails.Average,listDetails.FuelMode));;
        }

        

        /* private void FavoriteCar(object sender, ItemTappedEventArgs e)
         {
             var Listdetails = e.Item as CarModel;
             Listdetails.IsFavorite = !Listdetails.IsFavorite;
         }*/
        /* private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
{
    var item = e.SelectedItem as Data;
    if (item == null)
        return;

    await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

    // Manually deselect item.
    ItemsListView.SelectedItem = null;
}

private void OnTappedItem(object sender, ItemTappedEventArgs e)
{

}*/
    }
}
