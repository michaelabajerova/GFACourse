using System;

namespace DrawDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < num; row++)
            {

                for (int col = 0; col < num; col++)
                {

                    if (row == col || row == num - col - 1 || row == 0 || row == num - 1 || col == 0 || col == num - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
