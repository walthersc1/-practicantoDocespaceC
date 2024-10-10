using Microsoft.AspNetCore.Mvc;
using BackEnd.Business;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _service;

        public WeatherForecastController(IWeatherForecastService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> GetForecasts()
        {
            return await _service.GetForecastsAsync();
        }
    }
}
