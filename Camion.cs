public class Camion : Car
{
    public int Poidsmax { get; set; }

    public List<Colis> ColisList { get; set; }

    private int GetPoidsActuel(){
        int poidsActuel = 0; 
        foreach(var colis in ColisList){
            poidsActuel += colis.Poids;
        }
        return poidsActuel;

    }

    public int ChargeActuelle { 
        get{
            return GetPoidsActuel();

        } }

    public void Charger(Colis colis){
        var poidsfutur = colis.Poids + ChargeActuelle; 
    
        
        if(poidsfutur > Poidsmax)
        {
            Console.WriteLine("Le Poids maximum est dépassee");
        } else{
            ColisList.Add(colis);
            // ChargeActuelle += ChargeAjoutee;
            // Console.WriteLine($"Le poids ajouté est : {ChargeAjoutee}");
        }

    }

     
    public Camion(string marque, string modele, Colors couleur, int anneeFabrication, int poidsmax) : base(marque, modele, couleur, anneeFabrication)
    {
        Poidsmax = poidsmax;
        ColisList = new List<Colis>();
        
    }
}