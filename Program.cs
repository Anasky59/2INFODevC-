using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;

public class Program
{
        private static void Main(string[] args)
    {
            // Person Robert = new Person("Robert", "Hue", 86);
            Car c3 = new Car ("Citroen","C3", Colors.Vert, 2015);
            Colis colis1 = new Colis (1, 50, false);
            Console.WriteLine($"Nom complet de ma voiture : {c3.NomComplet} Année de fabrication {c3.AnneeFabrication}" );
            c3.StartEngine();

            Camion A400 = new Camion ("Scania", "A400", Colors.Vert, 2017, 8000);
            Console.WriteLine($"Nom complet de mon Camion : {A400.NomComplet} Année de fabrication {A400.AnneeFabrication} Poids max : {A400.Poidsmax} " );
            A400.Charger(colis1);
            Console.WriteLine(A400.ChargeActuelle);    
    }
}
