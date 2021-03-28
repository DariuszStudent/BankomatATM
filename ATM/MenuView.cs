using System;

namespace ATM
{
    public class MenuView
    {
        public void Intrduction()
        {
            Console.WriteLine("Witam w programie ATM, tu możesz wpłacić, wypłacić pieniądze oraz sprawdzić swój stan konta");
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("1. Wpłata gotówki");
            Console.WriteLine("2. Wypłata gotówki");
            Console.WriteLine("3. Sprawdź stan konta");
            Console.WriteLine("4. Wyloguj");
        }
    }
}
