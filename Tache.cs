public class Tache{
    public string Nom { get; private set;}
    public bool IsDone { get; set;}
    public Tache(string nom)
    {
        Nom = nom;
    }
}