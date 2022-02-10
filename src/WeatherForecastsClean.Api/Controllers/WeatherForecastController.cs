using Microsoft.AspNetCore.Mvc;
using WeatherForecastsClean.Application;

namespace WeatherForecastsClean.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastService _service;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public ActionResult<WeatherForecast> Get()
    {
        var result = _service.ProcessFTemperature();

        return Ok(result);
    }
}
