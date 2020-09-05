using System;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("Please enter a number:");
            int chickens = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int pigs = Convert.ToInt32(Console.ReadLine());

            int a = chickens * 2;
            int b = pigs * 4;

            Console.WriteLine("Animals have together this many legs: " + (a + b));

            Console.ReadLine();
        }
    }
}
