using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave2_4.console.Business;

namespace Opgave2_4.test
{
    [TestClass]
    public class TableCalculatorTest
    {
        private readonly ITableCalculator _sut = new TableCalculator();
        [TestMethod]
        public void CalcNumber3()
        {
            // Arrange 
            int[] expected = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };

            // Act 
            var actual = _sut.Calc(3).ToArray();

            // Assert
            CollectionAssert.AreEqual(expected, actual, "3 Tabellen er fejlet");
        }
    }
}
