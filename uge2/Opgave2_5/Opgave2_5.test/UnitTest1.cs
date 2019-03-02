using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave2_5.console.Business;

namespace Opgave2_5.test
{
    [TestClass]
    public class ModCheckerTest
    {
        private readonly IModChecker _sut = new ModChecker();

        [TestMethod]
        public void ModCheckerMin1Max3()
        {
            // Arrange 
            string[] expected = { "1 - Ulige", "2 - Lige", "3 - Ulige" };

            // Act 
            var actual = _sut.Check(1, 3).ToArray();

            // Assert
            CollectionAssert.AreEqual(expected, actual, "Fejl i mod checker");
        }
    }
}
