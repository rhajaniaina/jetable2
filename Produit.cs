public class Produit : IAffichable{
    public string Nom { get; }
    public decimal Prix { get; private set; }

    public Produit (string nom, decimal prix)
    {
        Nom = nom;
        Prix = prix;
    }

    public void Afficher(){
        Console.WriteLine("Voici le nom: " + Nom);
        Console.WriteLine("Voici le prix " + Prix);
    }

}