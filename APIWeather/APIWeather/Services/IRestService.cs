using System;
using System.Collections.Generic;
using System.Text;
using APIWeather.Model;
using System.Threading.Tasks;

namespace APIWeather.Services
{
    public interface IRestService
    {
        Task<WeatherRoot> GetWeather(string city);
    }
}
