using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using APIWeather.Model;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIWeather.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherRoot Weather { get; set; }
        public WeatherPage()
        {
            InitializeComponent();

            Weather = new WeatherRoot();
            this.BindingContext = Weather;
        }

        private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var city = searchBar.Text;
            Weather = await App.weatherManager.GetWeather(city);

            this.BindingContext = Weather;
        }
    }
}