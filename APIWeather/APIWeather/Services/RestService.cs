using System;
using System.Collections.Generic;
using System.Text;
using APIWeather.Model;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APIWeather.Services
{
    public class RestService : IRestService
    {
        HttpClient client;
        JsonSerializerOptions options;
        RootModel rootModel { get; set; }

        public RestService()
        {
            client = new HttpClient();
            options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }
        

         public async Task<WeatherRoot> GetWeather(string city)
        {
            Uri uri = new Uri($"{Constants.RestUrl}?q={city}&appid={Constants.ApiKey}");
            WeatherRoot weatherData = null;
            try
            {

                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<WeatherRoot>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return weatherData;
        }
    }
}
