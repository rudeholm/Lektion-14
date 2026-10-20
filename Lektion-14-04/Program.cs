/*
Uppgift 4: Typkontroll och typomvandling (is och as)
Loopa igenom din array från Uppgift 3. Använd nyckelordet is för att kontrollera om det
aktuella djuret är en Hund. Om det är en hund, typomvandla det och anropa en unik
metod ViftaPåSvansen().
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

    public void ViftaPåSvansen()
    {
        Console.WriteLine("Hunden viftar på svansen");
    }
}

class Katt : Djur
{
    public override void GörLjud()
    {
        Console.WriteLine("Katten jamar");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
       Djur[] djur = [new Hund(), new Katt()];

        foreach (var kreatur in djur)
        {
            kreatur.GörLjud();

            if (kreatur is Hund)
            {
                (kreatur as Hund)!.ViftaPåSvansen();
            }
        }
     }
}