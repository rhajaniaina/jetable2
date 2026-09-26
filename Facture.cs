public class Facture : IImprimable, IExportable
{
    public string Numero { get; set; }
    public string Client { get; set; }
    public decimal Montant { get; set; }

    public Facture(string numero, string client, decimal montant)
    {
        Numero = numero;
        Client = client;
        Montant = montant;
    }

    public void Imprimer()
    {
        Console.WriteLine($"Facture : {Numero}");
        Console.WriteLine($"Client : {Client}");
        Console.WriteLine($"Montant : {Montant} €");
    }

    public void Exporter(string fichier)
    {
        Console.WriteLine($"La facture {Numero} est exportée vers {fichier}");
    }
}