using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class SavingAccount : IAccount
    {
        public int Balance { get; set; }

        public SavingAccount(int balance)
        {
            this.Balance = balance;
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Your saving account balance is ${this.Balance}");
        }
    }
}
