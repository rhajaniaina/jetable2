public class Client : IAffichable
{
    public string Nom { get; }
    public string Email { get; }

    public Client (string nom, string email)
    {
        Nom = nom;
        Email = email;
    }

    public void Afficher()
    {
        Console.WriteLine("Voici le Nom: " + Nom);
        Console.WriteLine("Voici l'email: " + Email);
        
    }
}