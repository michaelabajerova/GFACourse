using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_Of_Simba.Models.ViewModel
{
    public class BankViewModel
    {

        public List<NewBankAccount> NewBankAccounts { get; set; }
        public BankViewModel()
        {
            NewBankAccounts = new List<NewBankAccount>();
            NewBankAccounts.Add(new NewBankAccount("Scar", 10000000.00, "lion",true, true));
            NewBankAccounts.Add(new NewBankAccount("Timon", 100.00, "meerkat", false, false));
            NewBankAccounts.Add(new NewBankAccount("Rafiki", 3500.00, "mandrill", false, false));
            NewBankAccounts.Add(new NewBankAccount("Pumba", 800.00, "warthog", false, false));
            NewBankAccounts.Add(new NewBankAccount("Shenzi", 7300.50, "hyena", false, true));
        }

    }
}
