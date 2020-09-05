using System;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("Please enter number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            if (num1 < num2)
            {
                Console.WriteLine(num2);
            }

            Console.ReadLine();
        }
    }
}
