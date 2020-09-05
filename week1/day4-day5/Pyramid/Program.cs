using System;
using System.Data;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int totalSpots = rows + (rows - 1);

            for (int row = 0; row < rows; row++)
            {
                for (int spot = 0; spot < totalSpots; spot++)
                {
                    if (spot >= totalSpots /2 - row && spot <= totalSpots / 2 + row)
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
