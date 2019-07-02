using System.Collections.Generic;
using ASP.NETCorewithVueandPicnic2.Models;

namespace ASP.NETCorewithVueandPicnic2.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}