using System;

namespace dnicolau_tdd_kata.tests
{
    public class StringCalculator
    {
        public int add(string numbers)
        {
            int result = 0;

            if (String.IsNullOrEmpty(numbers))
                result =  0;

            int number = 0;
            if (Int32.TryParse(numbers, out number))
                result = number;

            return result;
        }
    }
}