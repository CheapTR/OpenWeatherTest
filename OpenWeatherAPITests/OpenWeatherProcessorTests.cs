using OpenWeatherAPI;
using System;
using Xunit;

namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {

        

        [Fact]
        public void GetOneCallAsync_IfAPIKeyEmptyOrNull_ThrowArgumentException()
        {
            OpenWeatherProcessor OWP = OpenWeatherProcessor.Instance;
            Assert.ThrowsAsync<ArgumentException>(OWP.GetOneCallAsync);
        }
    }
}
