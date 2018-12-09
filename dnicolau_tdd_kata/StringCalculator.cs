using System;

namespace dnicolau_tdd_kata.tests
{
    public class StringCalculator
    {
        public int add(string numbers)
        {
            int result = 0;
            int number = 0;

            var numArray = numbers.Split(new char[] { ',', '\n' });

            foreach (string num in numArray)
            {
                if (Int32.TryParse(num.ToString(), out number))
                    result += number;
            }

            return result;
        }
    }
}