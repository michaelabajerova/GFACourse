using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert number:");
            bool isInputCorrect = int.TryParse(Console.ReadLine(), out int input);
            if (!isInputCorrect)
            {
                Console.WriteLine("Value must be integer");
            }
            bool isInputEven = input % 2 == 0 ? true : false;
            if (isInputEven)
            {
                Console.WriteLine($"Number {input} is EVEN");
            }
            else
            {
                Console.WriteLine($"Number {input} is ODD");
            }
        }
    }
}
