﻿using System;

namespace AnimalsInZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var reptile = new Reptile("Crocodile");
            var mammal = new Mammal("Koala");
            var bird = new Birds("Parrot");

            Console.WriteLine("Who want a baby?");
            Console.WriteLine(reptile.GetName() + ", " + reptile.WantChild());
            Console.WriteLine(mammal.GetName() + ", " + mammal.WantChild());
            Console.WriteLine(bird.GetName() + ", " + bird.WantChild());
        }
    }
}
