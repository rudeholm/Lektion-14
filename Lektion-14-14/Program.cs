/*
Uppgift 14: Lös koppling (Loose Coupling) via Interface
Skapa ett gränssnitt IMeddelandeTjänst med metoden Skicka(string text). Skapa
klassen EpostTjänst som implementerar gränssnittet. Skapa sedan en klass
Notifierare vars konstruktor tar emot ett IMeddelandeTjänst-objekt.
*/

public interface IMeddelandeTjänst
{
    public void Skicka(string text);
}

public class EpostTjänst : IMeddelandeTjänst
{
    public void Skicka(string text)
    {
        Console.WriteLine(text);
    }
}

public class Notifierare
{
    IMeddelandeTjänst MeddelandeTjänst;

    public Notifierare(IMeddelandeTjänst meddelandeTjänst)
    {
        MeddelandeTjänst = meddelandeTjänst;
    }

    public void Skicka(string text)
    {
        MeddelandeTjänst.Skicka(text);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var noti = new Notifierare(new EpostTjänst());
        noti.Skicka("Foo bar baz");
    }
}