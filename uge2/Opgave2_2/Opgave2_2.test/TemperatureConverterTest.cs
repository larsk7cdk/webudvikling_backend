using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave2_2.console.Business;

namespace Opgave2_2.test
{
    [TestClass]
    public class TemperatureConverterTest
    {
        private readonly ITemperatureConverter _sut = new TemperatureConverter();

        [TestMethod]
        public void CelsiusToFahrenheit()
        {
            // Arrange
            var expected = 57.2;

            // Act
            var actual = _sut.Convert("14,0c");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FahrenheitToCelsius()
        {
            // Arrange
            var expected = 2.222;
            // Act
            var actual = _sut.Convert("36f");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
