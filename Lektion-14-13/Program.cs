/*
Uppgift 13: Stark sammanhållning (High Cohesion)
Skapa en klass Rapport. Istället för att klassen både ska hämta data, formatera text och
skriva ut på en skrivare, ge den ett tydligt ansvar: att hålla rapportdata. Förklara
principen om Single Responsibility.
*/

// Endast databärare
public class RapportData
{
public string Titel { get; set; }
public string Innehåll { get; set; }
}

// Denna tar hand om utskriften
public class RapportUtskrivare
{
    public void SkrivUtTillKonsol(RapportData data)
    {
        System.Console.WriteLine($"--- {data.Titel} ---");
        System.Console.WriteLine(data.Innehåll);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var rapport = new RapportData
        {
            Titel = "Månadsrapport",
            Innehåll = "Nu jäklar går det bra!",
        };

        var utskrivare = new RapportUtskrivare();

        utskrivare.SkrivUtTillKonsol(rapport);

    }
}