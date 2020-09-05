using System;

namespace DrawChess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //

            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            for (int col = 0; col <= num; col++)
            {
                if (col % 2 == 0)
                {
                    Console.WriteLine("% % % %");
                }
                else
                {
                    Console.WriteLine(" % % % %");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
