using System;
using System.Data;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            int[,] matrix = new int[,]
            {
                   { 1, 0, 0, 0 },
                   { 0, 1, 0, 0 },
                   { 0, 0, 1, 0 },
                   { 0, 0, 0, 1 },
            };
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    Console.Write(String.Format("{0}", matrix[row, col]));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
