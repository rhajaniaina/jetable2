public class Commande : IAffichable
{
    public string Numero { get; }
    public decimal Montant { get; private set; }

    public Commande (string numero, decimal montant)
    {
        Numero = numero;
        Montant = montant;
    }

    public void Afficher()
    {
        Console.WriteLine("Voici le numéro: " + Numero);
        Console.WriteLine("Voici le montant: " + Montant);
    }

}
