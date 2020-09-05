using System;

namespace SecondsInDay
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int hours = 24 - currentHours;
            int minutes = 60 - currentMinutes;
            int sec = 60 - currentSeconds;

            Console.WriteLine(hours);
            Console.WriteLine(minutes);
            Console.WriteLine(sec);
            
            Console.ReadLine();


        }
    }
}
