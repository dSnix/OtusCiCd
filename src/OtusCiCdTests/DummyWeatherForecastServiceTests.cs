using System.Linq;
using NUnit.Framework;
using OtusCiCd.Services;

namespace OtusCiCdTests
{
    public class DummyWeatherForecastServiceTests
    {
        private DummyWeatherForecastService _service;

        [SetUp]
        public void Setup()
        {
            _service = new DummyWeatherForecastService();
        }

        [Test]
        public void GetWeatherForecasts_should_return_anything()
        {
            var weatherForecasts = _service.GetWeatherForecasts();
            Assert.True(weatherForecasts.Any());
        }
    }
}