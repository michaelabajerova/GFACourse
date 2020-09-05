using System;
using System.Threading;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            double length = 10;
            double width = 12;
            double height = 5;

            /// Surface ///
            double area = 2 * ((length * width) + (width * height) + (height * length));

            Console.WriteLine("Surface Area: " + area);
            
            

            //// Volume ////
            double vol = 10 * 12 * 5;

            Console.WriteLine("Volume: " + vol);

            Console.ReadLine();
            


        }
    }
}
