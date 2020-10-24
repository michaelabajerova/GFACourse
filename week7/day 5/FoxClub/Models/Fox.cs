using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
        public List<string> ListOfTricks { get; set; }
        private int countTrick;

        public int CountTrick
        {
            get
            {
                return countTrick = ListOfTricks.Count;
            }
        }

        public Fox(string name, string food, string drink)
        {
            this.Food = food;
            this.Drink = drink;
            this.Name = name;
            ListOfTricks = new List<string>();
        }

        public Fox(string name)
        {
            this.Name = name;
            ListOfTricks = new List<string>();
        }
    }
}
