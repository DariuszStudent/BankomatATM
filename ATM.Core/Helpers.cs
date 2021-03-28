using System;

namespace ATM.Core
{
    public static class Helpers
    {
        public static int JustNumbers(string message)
        {
            var userNumber = default(int);

            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out userNumber))
                {
                    Console.WriteLine(message);
                }
                if (userNumber.ToString().Length > 10) Console.WriteLine(message);
                else break;
            }
            return userNumber;
        }
    }
}
