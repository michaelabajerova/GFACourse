﻿using System;

namespace PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints all the even numbers between 0 and 500
            int i;
            for (i = 1; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }         
            }
            Console.ReadLine();

        }
    }
}
