using System;

namespace guessnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int usersNumber = Convert.ToInt32(Console.ReadLine());

            int ourNumber = 10;

            if (usersNumber > ourNumber)
                {
                Console.WriteLine("should be lower");
            }
            if (usersNumber < ourNumber)
            {
                Console.WriteLine("should be higher");
            }
            if (usersNumber == ourNumber)
            {
                Console.WriteLine("you found number 10");
            }
            Console.ReadLine();
        } 
        
    }
}
