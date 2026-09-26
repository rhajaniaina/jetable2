

var ak = new Produit("AK", 900m);
var Fadel = new Client("Fadel", "Fadel@lpb.com");



static void AfficherElement(IAffichable element)
{
    element.Afficher();
}

AfficherElement(new Commande("7790AH", 100m));

