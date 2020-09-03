using System;

namespace Greenfox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a distance in miles that you want to convert to kilometers:");
            bool isInputRight = double.TryParse(Console.ReadLine(), out double miles);

            if (!isInputRight)
            {
                Console.WriteLine("You provided wrong input. Please insert number. And try again.");
            }
            else
            {
                Console.WriteLine($" {miles} miles is { miles * 1.61} km. ");
            }

        }
    }
}
