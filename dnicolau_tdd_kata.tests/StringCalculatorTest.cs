using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace dnicolau_tdd_kata.tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        StringCalculator stringCalculator;
        static RandomNumbers randomNumbers;
        
        [TestInitialize()]
        public void Initialize()
        {
            stringCalculator = new StringCalculator();
            randomNumbers = new RandomNumbers();
        }

        private static IEnumerable<object[]> ReusableTestData =>
        new List<object[]> {
            new object[] { string.Empty, 0 },
            new object[] { "1", 1 },
            new object[] { "1,2", 3 },
            new object[] { "1\n2,3", 6 },
        };

        [DataTestMethod]
        [DynamicData(nameof(ReusableTestData))]
        public void add_numbers_numbersum(string numbers, int expected)
        {
            int actual = stringCalculator.add(numbers);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void add_unknownNumberOfNumbers_numbersum()
        {
            string numbers = randomNumbers.randomNumberArrayString;

            int expected = randomNumbers.randomNumberArraySum;

            int actual = stringCalculator.add(numbers);

            Assert.AreEqual(actual, expected);
        }

        class RandomNumbers
        {
            public string randomNumberArrayString;
            public int randomNumberArraySum;

            public RandomNumbers()
            {
                List<int> randomNumberArray = new List<int>();
                int randomNumber = new System.Random().Next(0, 100);
                for (int i = 0; i < randomNumber; i++)
                    randomNumberArray.Add(new System.Random().Next(0, 100));
                randomNumberArrayString = string.Join(',', randomNumberArray);
                randomNumberArraySum = randomNumberArray.Sum();
            }
        }
    }
}
