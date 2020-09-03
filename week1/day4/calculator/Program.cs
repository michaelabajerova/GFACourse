using System;
using System.Transactions;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");


            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");

            string input = Console.ReadLine();
            int result = 0;

            switch (input)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"The result of the calculation is {result}");
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"The result of the calculation is {result}");
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"The result of the calculation is {result}");
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"The result of the calculation is {result}");
                    break;

            }


        }
    }
}
