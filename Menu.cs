
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Menu
{
    ScoutRepository scoutRepository = new ScoutRepository();
    public void ShowMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Scoutföreningen Tuppen!");
            Console.WriteLine("Gör ett val:");
            Console.WriteLine("1. Lägg till ny scout");
            Console.WriteLine("2. Lista över scouter");
            Console.WriteLine("3. Lägg till aktivitet");
            Console.WriteLine("4. Ändra aktivitet");
            Console.WriteLine("5. Lista över kommande aktiviteter");
            Console.WriteLine("5. Lista över utförda aktiviteter");
            Console.WriteLine("A. Avsluta!");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                var scout = CreateScout();
                scoutRepository.AddScout(scout);    
                break;

                // case "2":

                // default:
            }
        }
    }
    private Scout CreateScout()
    {
        Console.WriteLine("För och -efternamn: ");
                string name = Console.ReadLine();
                Console.WriteLine("E-mail: ");
                string email = Console.ReadLine();
                Console.WriteLine("Telefonnummer: ");
                string phone = Console.ReadLine();
                Console.WriteLine("Födelsedatum: ");
                DateOnly birthDate = DateOnly.Parse(Console.ReadLine());

                Scout scout = new Scout(name, email, phone, birthDate);
                scoutRepository.AddScout(scout);

                return new Scout(name, email, phone, birthDate);
    }
}
