using System.Collections.Generic;
using OtusCiCd.Models;

namespace OtusCiCd.Services
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}