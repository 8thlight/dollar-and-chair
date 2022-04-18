using System.Linq;
using Application.Services;
using NUnit.Framework;
namespace Tests.ApplicationTest;

public class WeatherForecastServiceTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        WeatherForecastService weatherForecastService = new WeatherForecastService();
        var result = weatherForecastService.Forecasts();
        
        Assert.AreEqual(result.Count, 5, "This does not contain 5");
    }
}