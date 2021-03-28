using System;
using System.IO;

namespace ATM.Core
{
    public class FileManager
    {
        public string FileName { get; set; } = @"../../../bankCustomers.txt";

        public void AddToConstructor(Action<int, int, int> AddBankCustomer)
        {
            if (!File.Exists(FileName)) return;

            var readAllLines = File.ReadAllLines(FileName);
            foreach (var lines in readAllLines)
            {
                var lineItems = lines.Split(';');
                if (int.TryParse(lineItems[0], out var accountNumber) &&
                    int.TryParse(lineItems[1], out var accountBalance) &&
                    int.TryParse(lineItems[2], out var accountPin))
                {
                    AddBankCustomer(accountNumber, accountBalance, accountPin);
                }
            }
        }
    }
}
