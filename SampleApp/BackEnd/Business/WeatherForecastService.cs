using BackEnd.Models;
using BackEnd.Data;

namespace BackEnd.Business
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _repository;

        public WeatherForecastService(IWeatherForecastRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecastsAsync()
        {
            return await _repository.GetForecastsAsync();
        }
    }
}
