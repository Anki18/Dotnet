using System;

namespace AbstractFactory
{
    public interface IFactory
    {
        ISavingsAccount CreateSavingsAccount();
        ILoanAccount CreateLoanAccount();
    }

    public interface ISavingsAccount { }
    public interface ILoanAccount { }

    public class CitiLoanAccount : ILoanAccount
    {
        public CitiLoanAccount()
        {
            Console.WriteLine("Created citi loan account");
        }
    }
    
    public class CitiSavingAccount: ISavingsAccount
    {
        public CitiSavingAccount()
        {
            Console.WriteLine("Created citi saving account");
        }
    }
    
    public class NationalLoanAccount : ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Created citi loan account");
        }
    }
    
    public class NationalSavingAccount: ISavingsAccount
    {
        public NationalSavingAccount()
        {
            Console.WriteLine("Created citi saving account");
        }
    }
    
    public class CityFactory : IFactory
    {
        public ISavingsAccount CreateSavingsAccount()
        {
            return new CitiSavingAccount();
        }

        public ILoanAccount CreateLoanAccount()
        {
            return new CitiLoanAccount();
        }
    }

    public class NationalFactory : IFactory
    {
        public ISavingsAccount CreateSavingsAccount()
        {
            return new NationalSavingAccount();
        }

        public ILoanAccount CreateLoanAccount()
        {
            return new NationalLoanAccount();
        }
    }

    public enum Bank
    {
        Citi, National
    }
    public class Factory
    {
        public static IFactory CreateFactory(Bank bank)
        {
            switch (bank)
            {
                case Bank.Citi:
                    return new CityFactory();
                case Bank.National:
                    return new NationalFactory();
                default:
                    return null;
            }
        }
    }

    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var factory = Factory.CreateFactory(Bank.Citi);
            ILoanAccount la = factory.CreateLoanAccount();
            ISavingsAccount sa = factory.CreateSavingsAccount();
            
            factory = Factory.CreateFactory(Bank.National);
            ILoanAccount la1 = factory.CreateLoanAccount();
            ISavingsAccount sa1 = factory.CreateSavingsAccount();
        }
    }
}