/*
Uppgift 11: Skapa en egen undantagsklass (SaldoSaknasException)
Skapa en egen undantagsklass som heter SaldoSaknasException genom att låta den
ärva från basklassen Exception. Ge den en konstruktor som kan ta emot ett anpassat
felmeddelande.
*/

public class SaldoSaknasException : Exception
{
    public SaldoSaknasException(string msg) : base(msg)
    {
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            throw new SaldoSaknasException("Test av nytt exception");
        }
        catch (SaldoSaknasException e)
        {
            System.Console.WriteLine(e);
        }
    }
}