using System.Collections.Generic;
using System.IO;

namespace ATM.Core
{
    public class BankCustomerManager
    {
        public List<BankCustomer> BankCustomers { get; set; }

        FileManager fileManager = new FileManager();

        public BankCustomerManager()
        {
            BankCustomers = new List<BankCustomer>();

            fileManager.AddToConstructor(AddBankCustomer);
        }

        public void AddBankCustomer(int accountNumber, int accountBalance, int accountPin)
        {
            var bankCustomer = new BankCustomer(accountNumber, accountBalance, accountPin);

            BankCustomers.Add(bankCustomer);
        }

        public (bool, int) LoginCustomerBank(int accountCustomer, int accountPin)
        {
            var userLoginFlag = false;
            var accountLogin = default(int);
            foreach (var customer in BankCustomers)
            {
                if (customer.AccountNumber == accountCustomer && customer.AccountPin == accountPin)
                {
                    userLoginFlag = true;
                    accountLogin = accountCustomer;
                    return (userLoginFlag, accountLogin);
                }
            }
            return (userLoginFlag, accountLogin);
        }
    }
}
