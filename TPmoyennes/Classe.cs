namespace MHN_TPmoyennes            //MHN = Minh Hoang NGUYEN
{
    public class Classe
    {
        //Déclration des variables
        public string nomClasse {  get; private set; } 
        public List<Eleve> eleves { get; private set; }
        public List<Matiere> matieres { get; private set; }

        //Initialization des variables
        public Classe(string nom)                         
        {
            nomClasse = nom;
            eleves = new List<Eleve> ();
            matieres = new List<Matiere>();
        }

        //Méthode ajouterEleve avec 2 paramètres nom et prénom
        public void ajouterEleve(string prenom, string nom)        
        {
            if (eleves.Count >= 30)
            {
                Console.WriteLine("La classe a déjà 30 élèves");
            }
            else
            {
                eleves.Add(new Eleve(prenom, nom));
            }
        }

        //Méthode ajouterMatiere avec 1 paramètre nom
        public void ajouterMatiere(string nom)       
        {
            if (matieres.Count >= 10)
            {
                Console.WriteLine("La classe a déjà 10 matières");
            }
            else
            {
                matieres.Add(new Matiere(nom));
            }
        }

        //Méthode Moyenne pour toutes les matières de la classe
        public double Moyenne() 
        {
            return eleves.Any() ? Truncate.Truncate2decimale(eleves.Average(eleve => eleve.Moyenne())) : 0;
        }

        //Méthode (overload) Moyenne pour une seule matière de la classe
        public double Moyenne(int m) 
        {
            return eleves.Any() ? Truncate.Truncate2decimale(eleves.Average(eleve => eleve.Moyenne(m))) : 0;
        }
    }
}   

