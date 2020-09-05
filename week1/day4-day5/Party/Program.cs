using System;

namespace Party
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
           

            Console.WriteLine("Please enter two numbers: ");
            int girls = Convert.ToInt32(Console.ReadLine());
            int boys = Convert.ToInt32(Console.ReadLine());
            int together = girls + boys;
            int num = 20;

            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            if (girls == boys && together > num)
            {
                Console.WriteLine("The party is excelent!");
            }

            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            if (together > num && girls != boys)
            {
                Console.WriteLine("Quite cool party!");
            }

            // It should print: Average party...
            // If there are less people coming than 20
            if (together < num)
            {
                Console.WriteLine("Average party...");
            }

            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            if (girls == 0)
            {
                Console.WriteLine("Sausage party.");
            }
            Console.ReadLine();
        }
    }
}
