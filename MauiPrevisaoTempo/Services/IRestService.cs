using MauiPrevisaoTempo.Models;

namespace MauiPrevisaoTempo.Services;

public interface IRestService
{
    Task<WeatherData> GetWeatherData(string query);
}
