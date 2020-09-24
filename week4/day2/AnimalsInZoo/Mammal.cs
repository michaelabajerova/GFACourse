using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInZoo
{
    class Mammal : Animal
    {
        public Mammal(string name)
        {
            Name = name;
        }

        public string HaveFur()
        {
            return $"Look I'm furry.";
        }
        public override string Greet()
        {
            return $"Howdy partner";
        }
        public string GetName()
        {
            return Name;
        }
        public override string WantChild()
        {
            return $"It's humpy dumpy time";
        }
    }
}
