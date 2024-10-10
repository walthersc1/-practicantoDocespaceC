using BackEnd.Models;

namespace BackEnd.Data
{
    public interface IWeatherForecastRepository
    {
        Task<IEnumerable<WeatherForecast>> GetForecastsAsync();
    }
}
