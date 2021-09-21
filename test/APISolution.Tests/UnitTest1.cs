using System;
using Xunit;

namespace APISolution.Tests
{
   public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetTodayWeather()
        {
            var returnValue =controller.Get(1);
            Asset.Equal("cool",returnValue.value);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
