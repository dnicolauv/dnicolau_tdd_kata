using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace dnicolau_tdd_kata.tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        StringCalculator stringCalculator;

        [TestInitialize()]
        public void Initialize()
        {
            stringCalculator = new StringCalculator();
        }

        [DataTestMethod]
        [DataRow("", 0)]
        [DataRow("1", 1)]
        [DataRow("1,2", 3)]
        [DataRow("1,4,5,2", 12)] //Unkown number of numbers
        [DataRow("10,4,5,2", 21)] //Unkown number of numbers
        [DataRow("1\n2,3", 6)] //Allow new lines between numbers as separator
        public void add_numbers_numbersum(string numbers, int expected)
        {
            int actual = stringCalculator.add(numbers);
            Assert.AreEqual(actual, expected);
        }
    }
}
