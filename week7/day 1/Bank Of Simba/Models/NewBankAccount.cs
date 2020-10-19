using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_Of_Simba.Models
{
    public class NewBankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool IsGood { get; set; }
        public NewBankAccount(string name, double balance, string animalType, bool isKing, bool isGood)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
            IsGood = isGood;
        }
        public void RaiseBalance()
        {
            if(IsKing)
            {
                Balance += 100;
            }
            else
            {
                Balance += 10;
            }
        }
    }
}
