using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Pirate
    {
        public int Intoxitatedlvl { get; set; }
        public bool isAlive { get; set; }

        public string Name { get; set; }

        public void DrinkSomeRum()
        {
            Intoxitatedlvl++;
        }

        public Pirate(string name)
        {
            isAlive = true;
            Name = name;

        }
        public void HowIsItGoingMate()
        {
            if (Intoxitatedlvl <= 4)
            {
                Console.WriteLine("Pour me anudder");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'nk its goin");
            }
            Sleep();
        }
        public void Sleep()
        {
            Intoxitatedlvl = 0;
        }
        public void Die()
        {
            isAlive = false;
        }
        public void Brawl(Pirate enemy)
        {
            var ranNum = new Random().Next(1, 4);
            switch(ranNum)
            {
                case 1:
                    enemy.Die();
                    Console.WriteLine("{Name}killed{ enemy.Name}.");
                    break;
                case 2:
                    Die();
                    Console.WriteLine("{enemy.Name} killed {Name}.");
                    break;
                case 3:
                    enemy.Sleep();
                    Sleep();
                    Console.WriteLine("Both passed out.");
                    break;
            }
        }
    }
    
}
