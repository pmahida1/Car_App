using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Car_App
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public App(string DBLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
            DatabaseLocation = DBLocation;
        }
    }
}
