/*
Uppgift 15: Utmaning – Flexibel arkitektur vid lös koppling
Skapa ytterligare en klass SmsTjänst som implementerar IMeddelandeTjänst. Visa i
Main hur enkelt det är att byta ut EpostTjänst mot SmsTjänst i din Notifierare utan
att behöva ändra en enda rad kod inuti själva Notifierare-klassen.
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

public class SmsTjänst : IMeddelandeTjänst
{
    public void Skicka(string text)
    {
        Console.WriteLine(text);
    }
}

public class Notifierare
{
    public IMeddelandeTjänst MeddelandeTjänst { get; set; }

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
        noti.Skicka("Skickar epost");
        noti.MeddelandeTjänst = new SmsTjänst();
        noti.Skicka("Skickar SMS");
    }
}