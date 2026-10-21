/*
Uppgift 14: Lös koppling (Loose Coupling) via Interface
Skapa ett gränssnitt IMeddelandeTjänst med metoden Skicka(string text). Skapa
klassen EpostTjänst som implementerar gränssnittet. Skapa sedan en klass
Notifierare vars konstruktor tar emot ett IMeddelandeTjänst-objekt.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}