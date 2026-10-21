/*
Uppgift 13: Stark sammanhållning (High Cohesion)
Skapa en klass Rapport. Istället för att klassen både ska hämta data, formatera text och
skriva ut på en skrivare, ge den ett tydligt ansvar: att hålla rapportdata. Förklara
principen om Single Responsibility.
*/

// Använd separata klasser för att hämta och skriva ut data från Rapport.Data
public class Rapport
{
    public List<string> Data { get; set; } = [];
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}