public class Camion : Car
{
    public int Poidsmax { get; set; }

    public Stack<Colis> ColisList { get; set; }

    public void AfficherOrdreDeVidage(){
       
        foreach(var colis in ColisList){
            Console.WriteLine($"Colis Id: {colis.Id}");
        }
    }
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
            ColisList.Push(colis);
            // ChargeActuelle += ChargeAjoutee;
            // Console.WriteLine($"Le poids ajouté est : {ChargeAjoutee}");
        }
    }
    
    public Camion(string marque, string modele, Colors couleur, int anneeFabrication, int poidsmax) : base(marque, modele, couleur, anneeFabrication)
    {
        Poidsmax = poidsmax;
        ColisList = new Stack<Colis>();
        
    }
    public override void InitCheckList()
    {
        base.Checklist = new Queue<Tache>();
        base.Checklist.Enqueue(new Tache("Présence de la clé"));
        base.Checklist.Enqueue(new Tache("Permis sur Soi"));
        base.Checklist.Enqueue(new Tache("Essence Remplie"));
        base.Checklist.Enqueue(new Tache("Ceinture Mise"));
        base.Checklist.Enqueue(new Tache("Chargement Attaché"));
    }
}