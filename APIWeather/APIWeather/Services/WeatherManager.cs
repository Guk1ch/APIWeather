using System;
using System.Collections.Generic;
using System.Text;
using APIWeather.Model;
using System.Threading.Tasks;

namespace APIWeather.Services
{
    public class WeatherManager
    {
        IRestService restService;
        public WeatherManager(IRestService service)
		{
            restService = service;
		}
        public Task<List<EntryModel>> GetWeather(string city)
        {
            return restService.GetWeatherAsync(city);
        }

    }
}
