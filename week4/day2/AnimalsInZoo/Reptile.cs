using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInZoo
{
    class Reptile : Animal
    {
        public Reptile(string name)
        {
            Name = name;
        }
        public override string Greet()
        {
            return $"Howdy partner";
        }
        public string LayEggs()
        {
            return $"Let's make an omelett";
        }
        public string GetName()
        {
            return Name;
        }
        public override string WantChild()
        {
            return $"Imma do my thing and lay like a hundred eggs";
        }
    }
}
