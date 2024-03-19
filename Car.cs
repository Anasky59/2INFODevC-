using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Car
{
    public string Marque { get; set; }
    public string Modele { get; set; }
    public Colors Couleur { get; set; }
    public int AnneeFabrication { get; set; }
    public void StartEngine()
    {
        Console.WriteLine("Vrooooom");

    }
    public string NomComplet
    {
        get
        {
            return $"{Marque} {Modele}";
        }
    }

    public Car(string marque, string modele, Colors couleur, int anneeFabrication)
    {
        Marque = marque;
        Modele = modele;
        Couleur = couleur;
        AnneeFabrication = anneeFabrication;




    }


}