using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.

            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please provide the first number:");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please provide the second number:");

            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please provide the operation (+, -, * or /):");
            string operation = Console.ReadLine();
            // Get the operation from standard input:
            // string operation = ...

            // use the `switch` statement and the corresponding calculation
            // store the result of the calculation in the `result` variable
            double result = 0.0;
            
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine($"The result of the calculation is {result}");

            Console.ReadLine();
        }
    }
}
