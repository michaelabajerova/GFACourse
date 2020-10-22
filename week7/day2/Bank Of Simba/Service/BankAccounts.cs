using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank_Of_Simba.Models.ViewModel;

namespace Bank_Of_Simba.Models
{
    public class BankAccounts
    {
        public List<NewBankAccount> NewBankAccounts { get; set; }
        public BankAccounts()
        {
            NewBankAccounts = new List<NewBankAccount>()
            {
                new NewBankAccount("Simba", 2000.00, "lion", true, false),
                new NewBankAccount("Marvin", 2000.00, "zebra", false, true)
        };
        }       
    }
}
