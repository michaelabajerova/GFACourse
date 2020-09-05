using System;
using System.Data;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 1;
            count = num - 1;
            for (var k = 1; k <= num; k++)
            {
                for (var i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (var i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (var k = 1; k <= num - 1; k++)
            {
                for (var i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (var i = 1; i <= 2 * (num - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
