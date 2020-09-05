using System;

namespace OneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot

            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("One");
            }
            if (num == 1)
            {
                Console.WriteLine("One");
            }
            if (num == 2)
            {
                Console.WriteLine("Two");
            }
            if (num > 2)
            {
                Console.WriteLine("A lot");
            }
            Console.ReadLine();
        }
    }
}
