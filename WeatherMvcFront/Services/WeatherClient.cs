using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherMvcFront.Models;

namespace WeatherMvcFront.Services
{
    public class WeatherClient : IWeatherClient
    {
        private readonly HttpClient _httpClient;

        public WeatherClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw  new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<WeatherForecast>> GetWeather()
        {
            // Method name we need to call => weatherforecast
            return await _httpClient
                .GetFromJsonAsync<IEnumerable<WeatherForecast>>("/weatherforecast");
        }
    }
}
