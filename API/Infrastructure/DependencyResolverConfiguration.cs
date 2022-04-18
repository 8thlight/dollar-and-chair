using Application.Services;

namespace API.Infrastructure;

public static class DependencyResolverConfiguration
{
    public static void Configure(IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastService, WeatherForecastService>();
        // EXAMPLE: services.AddScoped<IRoomFinder, RoomFinder>();
    }
}