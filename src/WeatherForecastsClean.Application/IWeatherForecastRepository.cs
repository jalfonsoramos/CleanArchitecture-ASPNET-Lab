namespace WeatherForecastsClean.Application;

using WeatherForecastsClean.Core;

public interface IWeatherForecastRepository
{
    WeatherForecast[] GetForecasts();
}
