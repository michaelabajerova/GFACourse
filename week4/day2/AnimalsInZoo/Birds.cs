using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInZoo
{
    class Birds : Animal
    {
        public Birds (string name)
        {
            Name = name;
        }
        public string HasFeather()
        {
            return $"Look ma, I can fly.";
        }
        public override string WantChild()
        {
            return $"Imma do my thing and lay the egg";
        }
        public string GetName()
        {
            return Name;
        }
        public override string Greet()
        {
            return $"Whatcha looking at?";
        }
    }
}
