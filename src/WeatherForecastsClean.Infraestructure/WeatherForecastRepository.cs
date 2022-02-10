using WeatherForecastsClean.Application;
using WeatherForecastsClean.Core;

namespace WeatherForecastsClean.Infraestructure;

public class WeatherForecastRepository : IWeatherForecastRepository
{
    private static readonly string[] Summaries = new string[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Hot", "Sweltering", "Scorching"
    };

    public WeatherForecast[] GetForecasts()
    {
        var rng = new Random();

        return Enumerable.Range(1, 5).Select(x => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(x),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        }).ToArray();
    }
}
