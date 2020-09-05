using System;

namespace ParametricAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Enter 5 numbers: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4= Convert.ToDouble(Console.ReadLine());
            double num5 = Convert.ToDouble(Console.ReadLine());

            double Average = (num1 + num2 + num3 + num4 + num5) / 5;
            double Sum = num1 + num2 + num3 + num4 + num5;

            Console.WriteLine("Sum: " + Sum + ", Average: " + Average);
            

            Console.ReadLine();

        }
    }
}
