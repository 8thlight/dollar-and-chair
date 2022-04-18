using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Application.Services;

namespace API.Controllers;

[ApiController]
[Route("Weather")]
public class WeatherController : ControllerBase
{
    private IWeatherForecastService weatherForecastService;
    
    public WeatherController(IWeatherForecastService clouds)
    {
        weatherForecastService = clouds;
    }

    [HttpGet("forecast")]
    public IList<WeatherForecast> Forecasts()
    {
        return weatherForecastService.Forecasts();
    }
}