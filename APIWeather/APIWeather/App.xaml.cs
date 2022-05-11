using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using APIWeather.Views;
using APIWeather.Services;
using APIWeather.Model;

namespace APIWeather
{
    public partial class App : Application
    {
        public static WeatherManager weatherManager { get; private set; }
        public App()
        {
            InitializeComponent();

            weatherManager = new WeatherManager(new RestService());
            MainPage = new NavigationPage(new WeatherPage());
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
    }
}
