using System;

namespace DrawDiagonals
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = 10;
             

            for (int row = 0; row <= n; row++)
            {
                for (int col = 0; col <= n; col++)
                {
                    if (row == 0 || row == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (col == 0 || col == n)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }   
    }
}
