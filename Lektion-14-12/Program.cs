/*
Uppgift 12: Tillämpa det egna undantaget
Skapa en klass Bankkonto med metoden Uttag(double belopp). Om beloppet är
större än saldot ska programmet kasta ditt egna SaldoSaknasException. Fånga upp
detta specifika undantag i Main.
*/

public class SaldoSaknasException : Exception
{
    public SaldoSaknasException(string msg) : base(msg)
    {
    }
}

public class Bankkonto
{
    public decimal Saldo { get; set; }

    public void Uttag(decimal belopp)
    {
        if (belopp > Saldo)
            throw new SaldoSaknasException("FEL! Uttagsbeloppet överskrider tillgängligt saldo.");
        else
            Saldo -= belopp;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var konto = new Bankkonto() { Saldo = 1000.0M };
        decimal[] uttag = [500.0M, 550.0M];

        foreach (var belopp in uttag)
        {
            try
            {
                konto.Uttag(belopp);
                System.Console.WriteLine($"Nytt saldo efter uttag ({belopp:C2}): {konto.Saldo}");
            }
            catch (SaldoSaknasException e)
            {
                System.Console.WriteLine(e);
            }
        }
        System.Console.WriteLine($"Saldo: {konto.Saldo:C2}");
    }
}