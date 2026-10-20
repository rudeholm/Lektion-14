/*
Uppgift 7: Verklig hierarki – Användarsystem (Användare)
Skapa en basklass Användare och underklasserna Kund och Admin. Admin ska ha en
specifik metod NollställSystem(). Visa hur en lista med Användare kan hanteras
polymorft i ett fiktivt administrationsgränssnitt.
*/

class Användare
{

}

class Kund : Användare
{

}

class Admin : Användare
{
    void NollställSystem()
    {
        
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}