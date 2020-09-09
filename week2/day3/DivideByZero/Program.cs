﻿using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0
            try
            {
                Console.WriteLine("Enter number:");
                int number = int.Parse(Console.ReadLine());
                int result = 10 / number;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Fail");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
