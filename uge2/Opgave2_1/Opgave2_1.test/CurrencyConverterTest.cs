using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave2_1.console.Business;

namespace Opgave2_1.test
{
    [TestClass]
    public class CurrencyConverterTest
    {
        private readonly ICurrencyConverter _sut = new CurrencyConverter();

        [TestMethod]
        public void GetExchangeRate()
        {
            // Arrange 
            const double expected = 7.45;

            // Act
            var actual = _sut.ExchangeRate;

            // Assert
            Assert.AreEqual(expected, actual, "Valuta kurs");
        }

        [TestMethod]
        public void GetNewExchangeRate()
        {
            // Arrange 
            const double expected = 5.25;
            _sut.ChangeExchangeRate(5.25);

            // Act
            var actual = _sut.ExchangeRate;

            // Assert
            Assert.AreEqual(expected, actual, "Ny valuta kurs");
        }

        [TestMethod]
        public void KrToEuro()
        {
            // Arrange 
            const double expected = 10;

            // Act
            var actual = _sut.KrToEuro(74.5);

            // Assert
            Assert.AreEqual(expected, actual, "Kroner til Euro");
        }

        [TestMethod]
        public void EuroToKr()
        {
            // Arrange 
            const double expected = 22.35;

            // Act
            var actual = _sut.EuroToKr(3);

            // Assert
            Assert.AreEqual(expected, actual, "Euro til Kroner");
        }


        [TestMethod]
        public void KrToEuroWithNewExchangeRate()
        {
            // Arrange 
            _sut.ChangeExchangeRate(5);
            const double expected = 10;

            // Act
            var actual = _sut.KrToEuro(50);

            // Assert
            Assert.AreEqual(expected, actual, "Kroner til Euro med ny valuta kurs");
        }
    }
}