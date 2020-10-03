using System.ComponentModel.DataAnnotations;
using static NaturalNumberLibrary.NaturalNumber;
using System;

namespace NaturalNumberProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task #01. Sum and mul digits\n");
            Console.Write("Enter natural number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Sum: " + CalculateSumDigits(number));
                Console.WriteLine("Mul: " + CalculateMulDigits(number));
            }
            catch (ValidationException)
            {
                Console.WriteLine("Error: ValidationException");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: FormatException");
            }
        }
    }
}