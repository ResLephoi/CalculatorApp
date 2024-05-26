using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;

namespace StringCalculatorTest
{
    [TestClass]
    public class UnitTest
    {
        private StringCalculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new StringCalculator();
        }

        [TestMethod]
        public void Add_EmptyString_ReturnsZero()
        {
            var result = calculator.Add("");
            Assert.AreEqual(0, result);
        }
    }
}
