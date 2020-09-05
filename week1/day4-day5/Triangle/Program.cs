using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
             Console.ReadLine();
        }
    }
}

