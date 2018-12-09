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

        [TestMethod]
        public void add_onenumber_numbersum()
        {
            StringCalculator sut = new StringCalculator();
            string oneNumber = "1";
            int actual = sut.add(oneNumber);
            int expected = 1;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void add_twonumbers_numbersum()
        {
            StringCalculator sut = new StringCalculator();
            string twoNumbers = "1,2";
            int actual = sut.add(twoNumbers);
            int expected = 3;
            Assert.AreEqual(actual, expected);
        }
    }
}
