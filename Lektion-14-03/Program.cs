/*
Uppgift 3: Array av polymorfa objekt
Skapa ytterligare en underklass till Djur som heter Katt. Skapa sedan en array av
typen Djur[] i Main som innehåller både en Hund och en Katt. Loopa igenom arrayen
och anropa GörLjud() på varje element.
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
        }
    }
}