using CalculatorApp;

namespace UnitTest
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
        public void Add_EmptyString()
        {
            var result = calculator.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_SingleNumber()
        {
            var result = calculator.Add("4");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Add_TwoNumbers()
        {
            var result = calculator.Add("1,2");
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void Add_MultipleNumbers()
        {
            var result = calculator.Add("1,2,3,4,5");
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_NumbersWithNewLine()
        {
            var result = calculator.Add("1\n2,3");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Add_SupportsDifferentDelimiters()
        {
            var result = calculator.Add("//;\n1;2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Negatives not allowed: -3,-1")]
        public void Add_NegativeNumber_ThrowsException()
        {
            calculator.Add("-3,7,-1");
        }
    }
}