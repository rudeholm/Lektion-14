/*
Uppgift 10: Kasta egna undantag (ArgumentException)
Skapa en klass Person med egenskapen Ålder. I set-accessorn ska du kontrollera om
åldern är mindre än 0. Om den är det, kasta ett nytt ArgumentException med ett valfritt
felmeddelande.
*/

class Person
{
    public int Ålder
    {
        get;
        set
        {
            if (value < 0)
                throw new ArgumentException("Ålder får inte vara mindre än 0.");
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var person = new Person();
        person.Ålder = 47;
        person.Ålder = -1;
    }
}