/*
Uppgift 9: Fånga generella undantag (FormatExceptions)
Skapa ett program som försöker konvertera en felaktig sträng till en int. Använd ett
try-catch-block för att fånga upp FormatException. Lägg även till ett finally-block
som skriver ut "Körningen avslutad".
*/

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int.Parse("foo");
        }
        catch (FormatException)
        {
            
        }
        finally
        {
            Console.WriteLine("Körningen avslutas");
        }
    }
}