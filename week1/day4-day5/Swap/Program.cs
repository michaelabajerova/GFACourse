using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a + b;       
            b = a - b;    
            a = a - b;    
            Console.Write("After swap a= " + a + " b= " + b);

            Console.ReadLine();



        }
    }
}
