using System;

namespace Flyable
{
    class Program
    {
        static void Main(string[] args)
        {
            Helicopter heli = new Helicopter();
            heli.Fly();
            heli.Land();
            heli.TakeOff();
        }
    }
}
