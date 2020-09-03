using System;

namespace printlargernumb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                Console.WriteLine("The larger number is: {0}", firstNum);
            }
            else
            {
                Console.WriteLine("The greater number is: " + secondNum);
            }
        }
    }
}
