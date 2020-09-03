using System;

namespace Partyyy
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("How many girls are comming to the party?:");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.Write("And how many guys are coming?:");
            int b = Convert.ToInt32(Console.ReadLine());

            a = g + b;



            if (a >= 20)
            {
                Console.WriteLine("The party is excellent!");
            }

            else if (a > 20 && (b > g || g > b))
            {
                Console.WriteLine("Quite cool party!");
            }

            else if (a < 20)
            {
                Console.WriteLine("Avarage party...");
            }

            else if (g == 0)
            {
                Console.WriteLine("Sausage party");
            }






        }
    }
}
