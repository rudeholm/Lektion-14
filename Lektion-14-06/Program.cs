/*
Uppgift 6: Verklig hierarki – Betalsystem (Betalning)
Skapa en basklass Betalning med egenskapen Belopp och en virtuell metod
ProcessaBetalning(). Skapa underklasserna Kreditkort och Swish. Implementera
specifika utskrifter för hur varje betalmetod processas.
*/

class Betalning
{
    public decimal Belopp { get; set; }

    public virtual void ProcessaBetalning()
    {
        Console.WriteLine("Processa betalning");
    }
}

class Kreditkort : Betalning
{
    public override void ProcessaBetalning()
    {
        Console.WriteLine($"Processa betalning av {Belopp:C2} med kreditkort");
    }
}

class Swish : Betalning
{
    public override void ProcessaBetalning()
    {
        Console.WriteLine($"Processa betalning av {Belopp:C2} med Swish");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var kortbetalning = new Kreditkort() { Belopp = 129.0M };
        var swishbetalning = new Swish() { Belopp = 249.90M };

        kortbetalning.ProcessaBetalning();
        swishbetalning.ProcessaBetalning();
    }
}