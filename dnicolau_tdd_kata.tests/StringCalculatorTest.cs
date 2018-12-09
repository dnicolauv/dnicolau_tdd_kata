using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dnicolau_tdd_kata.tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void add_empty_zero()
        {
            StringCalculator sut = new StringCalculator();
            string empty = string.Empty;
            int actual = sut.add(empty);
            int expected = 0;
            Assert.AreEqual(actual, expected);
        }
    }
}
