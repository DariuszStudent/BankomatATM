using ATM.Core;
using System;

namespace ATM
{
    public class AtmApp
    {
        BankCustomerManager bankCustomerManager = new BankCustomerManager();

        public (bool, int) ShowLoginMenu()
        {
            Console.WriteLine("Żeby wykonać jakąkolwiek operacje musisz się zalogować: ");
            Console.WriteLine("Podaj login / nr konta: ");
            var login = Helpers.JustNumbers("Numer może zawierać do 10 cyfr, spróbuj jeszcze raz: ");
            Console.WriteLine("Podaj Pin do swojego konta: ");
            var password = Helpers.JustNumbers("Pin może zawierać do 10 cyfr, spróbuj jeszcze raz: ");

            var result = bankCustomerManager.LoginCustomerBank(login, password);

            return (result.Item1, result.Item2);
        }

        public void CheckAccountBalance()
        {
            
        }

        public void WithdrawalCash()
        {
            
        }

        public void DepositCash()
        {
            
        }
    }
}
