/*
Uppgift 1: Virtuell metod (Djur och Hund)
Skapa en basklass Djur med en virtuell metod (virtual) som heter GörLjud().
Metoden ska skriva ut ett generellt ljud. Skapa underklassen Hund som använder
override för att skriva ut "Hunden skäller".
*/

class Djur
{
    public virtual void GörLjud()
    {
        System.Console.WriteLine("Djur gör ljud");
    }
}

class Hund : Djur
{
    public override void GörLjud()
    {
        System.Console.WriteLine("Hunden skäller");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Djur djur = new();
        Djur hund = new Hund();

        djur.GörLjud();
        hund.GörLjud();
    }
}