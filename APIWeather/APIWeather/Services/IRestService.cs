using System;
using System.Collections.Generic;
using System.Text;
using APIWeather.Model;
 
namespace APIWeather.Services
{
    public interface IRestService
    {
        Task<WeatherData> GetWeatherData(string query);
    }
}
