using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
            // %%%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int i, j;


            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= num; j++)
                {
                    if (i == 1 || i == num ||  j == 1 || j == num)

                        Console.Write("%");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
