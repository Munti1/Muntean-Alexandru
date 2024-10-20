using System;

namespace ConsoleApp
{
    public static class MathOperations
    {
        public static void Perform()
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Addition: {a + b}");
            Console.WriteLine($"Subtraction: {a - b}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Division: {a / b}");
            Console.WriteLine($"Modulus: {a} % {b} = {a % b}");
        }
    }
}