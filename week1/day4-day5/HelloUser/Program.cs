using System;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user!");
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.ReadLine();
        }
    }
}
