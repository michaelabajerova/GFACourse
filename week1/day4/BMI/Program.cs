using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double massInKg = 81.2;
            double heightInM = 1.78;



            Console.WriteLine(massInKg / (heightInM * heightInM));
            Console.ReadLine();
        }
    }
}
