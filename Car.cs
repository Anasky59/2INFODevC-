using System;
using System.Collections.Generic;

public class Car
{
    public string Marque { get; set; }
    public string Modele { get; set; }
    public Colors Couleur { get; set; } // Je suppose que Colors est une erreur et que vous voulez une chaîne de caractères pour la couleur
    public Queue<Tache> Checklist { get; set; }
    public int AnneeFabrication { get; set; }
    

    public string NomComplet
    {
        get
        {
            return $"{Marque} {Modele}";
        }
    }
    
    public void StartEngine()
    {
        AskForCheckList();
        while (!IsChecklistOk())
        {
            Recup();
            AskForCheckList();
        }
        {
            Console.WriteLine("Vrooooom");
            
        

        }
        
    }

    public Car(string marque, string modele, Colors couleur, int anneeFabrication)
    {
        Marque = marque;
        Modele = modele;
        Couleur = couleur;
        AnneeFabrication = anneeFabrication;
        Checklist = new Queue<Tache>();
        InitCheckList();
    }

    public virtual void InitCheckList(){
        Checklist = new Queue<Tache>();
        Checklist.Enqueue(new Tache("Présence de la clé"));
        Checklist.Enqueue(new Tache("Permis sur Soi"));
        Checklist.Enqueue(new Tache("Essence Remplie"));
        Checklist.Enqueue(new Tache("Ceinture Mise"));
    }

    public bool IsChecklistOk()
    {
        foreach (var item in Checklist)
        {
            if (!item.IsDone)
            {
                // Console.WriteLine($"Cet élément {item.Nom} n'a pas été effectué");
                return false;
            }
        }
        return true;
    }

    public void AskForCheckList()
    {
        foreach (var question in Checklist)
        {
            Console.WriteLine($"Est-ce que tu as fait la tâche suivante : {question.Nom} ? (o : oui, n: non)");
            var response = Console.ReadLine();
            if (response == "o")
                question.IsDone = true;
        }
    }

    public void Recup()
    {
        foreach (var item in Checklist)
        {
            if (!item.IsDone)
            {
                Console.WriteLine($"Cet élément {item.Nom} n'a pas été effectué");
            }
        }

        
    }
}

