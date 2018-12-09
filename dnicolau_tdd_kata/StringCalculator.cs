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

            return result;
        }
    }
}