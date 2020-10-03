using System.ComponentModel.DataAnnotations;
using System;

namespace NaturalNumberLibrary
{
    public class NaturalNumber
    {
        public static int FIRST_NATURAL_NUMBER = 1;

        public static bool CheckNaturalNumber(int number)
        {
            return number >= FIRST_NATURAL_NUMBER;
        }

        public static int CalculateSumDigits(int number)
        {
            if (!CheckNaturalNumber(number))
            {
                throw new ValidationException();
            }

            int result = 0;

            while (number != 0)
            {
                result += number % 10;
                number /= 10;
            }

            return result;
        }

        public static int CalculateMulDigits(int number)
        {
            if (!CheckNaturalNumber(number))
            {
                throw new ValidationException();
            }

            int result = 1;

            while (number != 0)
            {
                result *= number % 10;
                number /= 10;
            }

            return result;
        }
    }
}