using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MHN_TPmoyennes            //MHN = Minh Hoang NGUYEN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création d'une classe
            Classe sixiemeA = new Classe("6eme A");

            //Ajout des élèves à la classe
            sixiemeA.ajouterEleve("Jean", "RAGE");
            sixiemeA.ajouterEleve("Paul", "HAAR");
            sixiemeA.ajouterEleve("Sibylle", "BOQUET");
            sixiemeA.ajouterEleve("Annie", "CROCHE");
            sixiemeA.ajouterEleve("Alain", "PROVISTE");
            sixiemeA.ajouterEleve("Justin", "TYNDERNIER");
            sixiemeA.ajouterEleve("Sacha", "TOUILLE");
            sixiemeA.ajouterEleve("Cesar", "TICHO");
            sixiemeA.ajouterEleve("Guy", "DON");

            //Ajout de matières étudiées par la classe
            sixiemeA.ajouterMatiere("Français");
            sixiemeA.ajouterMatiere("Anglais");
            sixiemeA.ajouterMatiere("Physique/Chimie");
            sixiemeA.ajouterMatiere("Histoire");
            Random random = new Random();

            //Ajout de 5 notes à chaque élève et dans chaque matière
            for (int ieleve = 0; ieleve < sixiemeA.eleves.Count; ieleve++)
            {
                for (int matiere = 0; matiere < sixiemeA.matieres.Count; matiere++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sixiemeA.eleves[ieleve].ajouterNote(new Note(matiere, (float)((6.5 + random.NextDouble() * 34)) / 2.0f));
                        //Note minimale = 3
                    }
                }
            }

            Eleve eleve = sixiemeA.eleves[6];
            //Afficher la moyenne d'un élève dans une matière
            Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne en " + sixiemeA.matieres[1] + " : " + eleve.Moyenne(1) + "\n");
            //Afficher la moyenne générale du même élève
            Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne Générale : " + eleve.Moyenne() + "\n");
            //Afficher la moyenne de la classe dans une matière
            Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne en " + sixiemeA.matieres[1] + " : " + sixiemeA.Moyenne(1) + "\n");
            //Afficher la moyenne générale de la classe
            Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne Générale : " + sixiemeA.Moyenne() + "\n");
            Console.Read();
        }
    }
    public class Note 
    {
        public int matiere { get; private set; }
        public float note { get; private set; }

        public Note (int m, float n)
        {
            matiere = m;
            note = n;
        }
    }
    public class Matiere
    {
        public string Nom {  get; private set; }
        public Matiere(string nom)
        {
            Nom = nom;
        }

        // Remplacez la méthode ToString pour renvoyer le nom de l’objet
        public override string ToString() 
        {
            return Nom;
        }
    }

    //Tronquage les moyennes à 2 chiffres après la virgule
    public static class Truncate         
    {
        public static double Truncate2decimale(double moyenne)
        {
            return Math.Truncate(moyenne * 100) / 100;
        }
    }
}   

