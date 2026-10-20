/*
Uppgift 2: Polymorfism med basklassreferens
Använd klasserna från Uppgift 1. Skapa en variabel av typen Djur i Main, men
instansiera den som en Hund. Anropa GörLjud() och observera polymorfismen i
praktiken.
*/

class Djur
{
    public virtual void GörLjud()
    {
        Console.WriteLine("Djur gör ljud");
    }
}

class Hund : Djur
{
    public override void GörLjud()
    {
        Console.WriteLine("Hunden skäller");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Djur hund = new Hund();

        hund.GörLjud();
    }
}