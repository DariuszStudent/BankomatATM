using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var atmApp = new AtmApp();
            var menuView = new MenuView();

            while (true)
            {
                Console.Clear();
                menuView.Intrduction();
                var userLogin = atmApp.ShowLoginMenu();
                var exit = false;

                if (userLogin.Item1)
                {
                    while (!exit)
                    {
                        Console.Clear();
                        Console.WriteLine("Zalogowany użytkownik: " + userLogin.Item2);
                        menuView.ShowMainMenu();
                        var userInput = Console.ReadKey();
                        switch (userInput.KeyChar)
                        {
                            case '1':
                                atmApp.DepositCash();
                                break;
                            case '2':
                                atmApp.WithdrawalCash();
                                break;
                            case '3':
                                atmApp.CheckAccountBalance();
                                break;
                            case '4':
                                userLogin.Item1 = false;
                                userLogin.Item2 = 0;
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Złe dane wejściowe");
                                break;
                        }
                    }
                }
            }
        }
    }
}
