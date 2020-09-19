using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Station station = new Station(100);
            Car car = new Car();

            Console.WriteLine(station.ReFill(car));
        }
    }
}
