using System;

namespace Factory
{
    public enum Bank
    {
        Citi, National
    }
    public interface ISavingsAccount
    {
        string AccountNumber { get; set; }
        decimal Balance { get; set; }
    }

    public class NationalSavingAccount : ISavingsAccount
    {
        public NationalSavingAccount(string accountNumber)
        {
            Balance = 2000;
            AccountNumber = accountNumber;

        }

        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }
    
    public class CitiSavingAccount : ISavingsAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public CitiSavingAccount(string accountNumber)
        {
            Balance = 5000;
            AccountNumber = accountNumber;
        }
    }

    public interface ISavingAccountFactory
    {
        ISavingsAccount GetSavingsAccount(Bank bank, string accountNo);
    }

    public class SavingAccountFactory : ISavingAccountFactory
    {
        public ISavingsAccount GetSavingsAccount(Bank bank, string accountNo)
        {
            switch (bank)
            {
                case Bank.Citi:
                    return new CitiSavingAccount(accountNo);
                case Bank.National:
                    return new NationalSavingAccount(accountNo);
                default:
                    return null;
            }
        }
    }

    static class Program
    {
        private static void Main(string[] args)
        {
            var factory = new SavingAccountFactory();
            var account = factory.GetSavingsAccount(Bank.Citi, "CITI-3243");
            Console.WriteLine($"Balance : {account.Balance} and AccountNo : {account.AccountNumber}");
            
            var nationalAccount = factory.GetSavingsAccount(Bank.National, "National-3243");
            Console.WriteLine($"Balance : {nationalAccount.Balance} and AccountNo : {nationalAccount.AccountNumber}");
        }
    }
}