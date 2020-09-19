using System;
using System.Collections.Generic;
using System.Text;

namespace FleetOfThings
{
    class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
            
        }
        public void CompleteThing(int number)
        {
            Things[number].Complete();
        }
        public void Print()
        {
            for (int i = 0; i < Things.Count; i++)
            {
                if (Things[i].Status().Equals(true))
                {
                    Console.WriteLine($"{i + 1}. [x] {Things[i].GetName()}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. [ ] {Things[i].GetName()}");
                }
            }
        }
        
        
    }
}
