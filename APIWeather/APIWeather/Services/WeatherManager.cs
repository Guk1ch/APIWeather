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
        public Task<WeatherRoot> GetWeather(string city)
        {
            return Task.Run(()=>restService.GetWeather(city));
        }

    }
}
