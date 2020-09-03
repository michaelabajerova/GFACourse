using System;
using System.ComponentModel.Design.Serialization;
using System.Threading;

namespace Average_Of_Inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is 10 devided by 2?");
            Console.ReadLine();
            Console.WriteLine("5");
            Console.ReadLine();
            Console.WriteLine("how tall are you?");
            Console.ReadLine();
            Console.WriteLine(173);
            Console.ReadLine();
            Console.WriteLine("How many diopter do you have?");
            Console.ReadLine();
            Console.WriteLine(4);
            Console.ReadLine();
            Console.WriteLine("How many pets do you have?");
            Console.ReadLine();
            Console.WriteLine("0");
            Console.ReadLine();
            Console.WriteLine("How many times you flew by plane");
            Console.ReadLine();
            Console.WriteLine("1");

            int a = 5;
            int b = 173;
            int c = 4;
            int d = 0;
            int e = 1;

            int sum = a + b + c + d + e;
            int average = sum / 4;
            Console.WriteLine("The average of " + a + ", " + b + ", " + c + " , " + d + " , " + e + " is " + average);



        }
    }
}
