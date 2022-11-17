using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class CurrentAccount:IAccount
    {
        public int Balance { get; set; }

        public CurrentAccount(int balance)
        {
            this.Balance = balance;
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Your saving account balance is ${this.Balance}");
        }
    }
}
