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
        public void add_numbers_numbersum(string numbers, int expected)
        {
            int actual = stringCalculator.add(numbers);
            Assert.AreEqual(actual, expected);
        }
    }
}
