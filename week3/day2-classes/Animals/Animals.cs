using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Animals
    {
        public int hunger = 50;
        public int thirst = 50;

        public int Eat()
        {
            return hunger--;
        }
        public int Drink()
        {
            return thirst--;
        }
        public int Play()
        {
            return hunger++;
            return thirst++;
        }
    }
}
