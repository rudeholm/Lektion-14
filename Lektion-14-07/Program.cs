/*
Uppgift 7: Verklig hierarki – Användarsystem (Användare)
Skapa en basklass Användare och underklasserna Kund och Admin. Admin ska ha en
specifik metod NollställSystem(). Visa hur en lista med Användare kan hanteras
polymorft i ett fiktivt administrationsgränssnitt.
*/

public class Användare
{
    public string Namn { get; set; }
}

public class Kund : Användare
{

}

public class Admin : Användare
{
    public void NollställSystem()
    {
        Console.WriteLine("Kritiskt meddelande: Hela systemet har återställts av Admin.");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Användare[] systemAnvändare = [
            new Användare { Namn="Bar" },
            new Admin { Namn="Foo" },
        ];

        foreach (var användare in systemAnvändare)
        {
            Console.WriteLine($"Inloggad: {användare.Namn}");
            if (användare is Admin a)
            {
                Console.WriteLine($"{a.Namn} är Admin");
                a.NollställSystem();
            }
        }
    }
}