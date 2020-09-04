using System;

namespace OneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            

            if (a <= 0)
            {
                Console.WriteLine("Not enough");
            }
            if (a == 1)
            {
                Console.WriteLine("One");
            }
            if (a == 2)
            {
                Console.WriteLine("Two");
            }
            if (a > 2)
            {
                Console.WriteLine("A Lot");
            }

            Console.ReadLine();
        }
    }
}
