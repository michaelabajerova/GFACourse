using System;
using System.Collections.Generic;
using System.Text;

namespace Flyable
{
    class Helicopter : Vehicle, IFlyable
    {
        public void Land()
        {
            Console.WriteLine("I can land.");
        }
        public void Fly()
        {
            Console.WriteLine("I believe I can flyyyyy \nI believe I can touch the skyyyy \nI think about it every night and day \nBombing the jihadists far awaaaay.");
        }
        public void TakeOff()
        {
            Console.WriteLine("Your clothes");
        }
    }
}
