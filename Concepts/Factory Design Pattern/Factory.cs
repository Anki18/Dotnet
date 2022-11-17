using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class Factory : AccountFactory
    {
        public override IAccount GetAccount(string type)
        {
            switch (type)
            {
                case "Saving":
                    return new SavingAccount(1000);

                case "Current":
                    return new CurrentAccount(2000);
                
                default:
                    throw new Exception("");
            }
        }
    }
}
