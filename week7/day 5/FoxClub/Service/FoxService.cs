
using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class FoxService
    {
        public List<Fox> Foxes { get; private set; }
        public List<string> Food { get; private set; }
        public List<string> Drink { get; private set; }
        public List<string> Tricks { get; private set; }

        public FoxService()
        {
            Foxes = new List<Fox>();
            Food = new List<string>() { "pizza", "burgers", "pasta", "candy", "kebab" };
            Drink = new List<string>() { "coke", "tea", "coffee", "beer", "water", "juice" };
            Tricks = new List<string>() { "coding", "cooking", "gaming", "singing", "skiing", "fighting" };
        }

        public Fox FindByName(string name)
        {
            return Foxes.Find(p => p.Name.Equals(name));
        }

        public void AddFox(Fox fox)
        {
            Foxes.Add(fox);
        }
    }
}