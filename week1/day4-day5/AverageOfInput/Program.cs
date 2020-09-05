using System;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Please enter 5 numbers: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            int sum = num + num1 + num2 + num3 + num4;
            Console.WriteLine("Sum of these numbers is: " + sum);
            Console.ReadLine();

            int average = sum / 5;
            Console.WriteLine("The average of number is: " + average);
            Console.ReadLine();

        }
    }
}
