using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInZoo
{
    abstract class Animal
    {
        protected string Name { get; set; }
        protected int Age { get; set; }

        protected string IsDangerous { get; set; }

        public void Animals(string name, int age, string danger)
        {
            Name = name;
            Age = age;
            IsDangerous = danger;
        }
        public virtual string Greet()
        {
            return $"Hello";
        }
        public virtual string WantChild()
        {
            return $"I wanna have babies";
        }
        public virtual string WantsToKillYou()
        {
            return $"You're dead to me";
        }

    }
}
