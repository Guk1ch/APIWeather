using System;
using System.Collections.Generic;
using System.Text;
using APIWeather.Model;

namespace APIWeather.Services
{
    public class RestService : IRestService
    {
        HttpClient client;

        public RestService()
        {
            client = new HttpClient();
        }
        public async Task<List<WeatherData>> GetWeatherAsync()
        {
            List<WeatherData> list = new List<WeatherData>();

            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
                HttpResponseMessage response = await client.GetAsync(Constants.RestUrl);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    //list = JsonSerializer.Deserialize<List<WeatherData>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return list;
        }
        public async Task<WeatherData> GetWeatherData(string query)
        {
            WeatherData weat = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    weat = JsonConvert.DeserializeObject<WeatherData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return weat;
        }
    }
}
