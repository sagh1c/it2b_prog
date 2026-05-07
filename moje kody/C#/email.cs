class Program
{
    static bool Email(string email)
    {
        int pocetZavinacu = 0;
        int poziceZavinace = -1;

        for (int i = 0; i < email.Length; i++)
        {
            if (email[i] == '@')
            {
                pocetZavinacu++;
                poziceZavinace = i;
            }
        }

        if (pocetZavinacu != 1 || poziceZavinace == 0)
        {
            return false;
        }

        for (int i = poziceZavinace + 1; i < email.Length; i++)
        {
            if (email[i] == '.')
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        Console.WriteLine("Napis emailovou adresu");
        string email = Console.ReadLine();

        if (Email(email))
        {
            Console.WriteLine("Email je platný");
        }
        else
        {
            Console.WriteLine("Email je neplatný");
        }
    }
}