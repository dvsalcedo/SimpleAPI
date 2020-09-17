using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController weather = new WeatherForecastController();

        [Fact]
        public void GetReturnsSimpleTest()
        {
            var returnValue = weather.Get();
            Assert.Equal("This is a simple test", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
