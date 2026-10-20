/*
Uppgift 8: Enkel Try-Catch (Division med noll)
Skapa ett program som ber användaren mata in två tal och dividerar dem. Kapsla in
beräkningen i ett try-catch-block som fångar upp ett DivideByZeroException och ger
användaren ett snyggt felmeddelande.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Mata in ett heltal att dividera med ett annat heltal: ");
        var täljare = int.Parse(Console.ReadLine()!);
        Console.Write("Mata in ett andra heltal: ");
        var nämnare = int.Parse(Console.ReadLine()!);

        int kvot = 0;

        try
        {
            kvot = täljare / nämnare;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("FEL! Division med noll!");
        }
        Console.WriteLine("Resultat: {0}", kvot);
    }
}