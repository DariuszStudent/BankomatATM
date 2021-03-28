namespace ATM.Core
{
    public class BankCustomer
    {
        public int AccountNumber { get; private set; }
        public int AccountBalance { get; private set; }
        public int AccountPin { get; private set; }

        public BankCustomer (int accountNumber, int accountBalance, int accountPin)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            AccountPin = accountPin;
        }

        public override string ToString()
        {
            return AccountNumber.ToString() + ";" + AccountBalance.ToString() + ";" + AccountPin.ToString();
        }
    }
}
