

var ak = new Produit("AK", 900m);
var Fadel = new Client("Fadel", "Fadel@lpb.com");
var commande1 = new Commande("7790AH", 100m);



static void AfficherElement(IAffichable element)
{
    element.Afficher();
}

List<IAffichable> elements = new();
elements.Add(ak);
elements.Add(Fadel);
elements.Add(commande1);

foreach (var element in elements)
{
    element.Afficher();
}
