namespace MHN_TPmoyennes            //MHN = Minh Hoang NGUYEN
{
    public class Classe
    {
        public string nomClasse {  get; private set; }          //Déclration des variables
        public List<Eleve> eleves { get; private set;}
        public List<Matiere> matieres { get; private set; }
        public Classe(string nom)                                //Initialization des variables
        {
            nomClasse = nom;
            eleves = new List<Eleve> ();
            matieres = new List<Matiere>();
        }
        public void ajouterEleve(string prenom, string nom)        //Méthode ajouterEleve avec 2 paramètres nom et prénom
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
        public void ajouterMatiere(string nom)       //Méthode ajouterMatiere avec 1 paramètre nom
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
        public double Moyenne()             //Méthode Moyenne pour toutes les matières de la classe
        {
            return eleves.Any() ? Truncate.Truncate2decimale(eleves.Average(eleve => eleve.Moyenne())) : 0;
        }
        public double Moyenne(int m)        //Méthode (overload) Moyenne pour une seule matière de la classe
        {
            return eleves.Any() ? Truncate.Truncate2decimale(eleves.Average(eleve => eleve.Moyenne(m))) : 0;
        }
    }
}   

