/*
Uppgift 5: Statisk polymorfism (Metodöverlagring)
Skapa en klass Skrivare. Skapa två metoder med samma namn SkrivUt(). Den ena
ska ta emot en string och den andra en int. Visa hur kompilatorn väljer rätt metod
baserat på parametern (överlagring/overloading).
*/

class Skrivare
{
    public static void SkrivUt(string s)
    {
        Console.WriteLine(s);
    }

    public static void SkrivUt(int i)
    {
        Console.WriteLine(i);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Skrivare.SkrivUt("Text");
        Skrivare.SkrivUt(23);
    }
}