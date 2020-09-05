using System;

namespace MileToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it

            

            Console.WriteLine("PLease enter distance in miles that you want to convert:");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilo = miles * 1.6;

            Console.WriteLine(kilo + " kilometres");

            Console.ReadLine();






        }
    }
}
