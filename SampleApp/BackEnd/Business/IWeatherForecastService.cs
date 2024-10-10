using BackEnd.Models;

namespace BackEnd.Business
{ 
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetForecastsAsync();
    }
}
