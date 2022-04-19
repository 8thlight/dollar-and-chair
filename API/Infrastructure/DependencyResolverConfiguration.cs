using Application.Services;

namespace API.Infrastructure;

public static class DependencyResolverConfiguration
{
    public static void Configure(IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastService, WeatherForecastService>();
        services.AddScoped<IAuctionService, AuctionService>();
        // EXAMPLE: services.AddScoped<IRoomFinder, RoomFinder>();
    }
}