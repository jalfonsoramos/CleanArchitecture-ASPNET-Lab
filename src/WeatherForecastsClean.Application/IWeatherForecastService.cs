using WeatherForecastsClean.Core;

namespace WeatherForecastsClean.Application;

public interface IWeatherForecastService
{
    List<WeatherForecast> ProcessFTemperature();
}

public class WeatherForecastService : IWeatherForecastService
{
    private readonly IWeatherForecastRepository _repository;

    public WeatherForecastService(IWeatherForecastRepository repository)
    {
        this._repository = repository;
    }

    public List<WeatherForecast> ProcessFTemperature()
    {
        var forecast = _repository.GetForecasts();

        var processed = new List<WeatherForecast>();

        foreach (var f in forecast)
        {
            f.TemperatureF = 32 + (int)(f.TemperatureC / 0.5556);
            processed.Add(f);
        }

        return processed;
    }
}