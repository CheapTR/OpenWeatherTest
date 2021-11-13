using OpenWeatherAPI;
using System;
using Xunit;

namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {
        OpenWeatherProcessor OWP = OpenWeatherProcessor.Instance;

        [Fact]
        public async void GetOneCallAsync_IfAPIKeyEmptyOrNull_ThrowArgumentException()
        {
            //Arrange
            //Act
            //Assert
            var ex = await Assert.ThrowsAsync<ArgumentException>(OWP.GetOneCallAsync);
            Assert.Contains("ApiKey null or empty!", ex.Message);
        }

        [Fact]
        public void GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
        }
        [Fact]
        public void GetOneCallAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
        }
        [Fact]
        public void GetCurrentWeatherAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
        }
    }
}
