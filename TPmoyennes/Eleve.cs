namespace MHN_TPmoyennes        //MHN = Minh Hoang NGUYEN
{
    public class Eleve
    {
        //Déclration des variables
        public string prenom { get; private set; }   
        public string nom {  get; private set; }
        public List<Note> notes { get; private set; }

        //Initialization des variables
        public Eleve(string Prenom, string Nom)     
        {
            prenom = Prenom;
            nom = Nom;
            notes = new List<Note>();
        }

        //Méthode ajouterNote avec 1 paramètre note
        public void ajouterNote(Note note)          
        {
            if (notes.Count >= 200)
            {
                Console.WriteLine($"{prenom} {nom} a déjà reçu 200 notes.");
            }
            else 
            { 
                notes.Add(note);
            }
        }

        //Méthode Moyenne pour toutes les matières d'un élève
        public double Moyenne()         
        {
            //Méthode GroupBy regroupe les notes dans la liste notes qui appartiennent à la même matière
            var matiereGroupes = notes.GroupBy(s => s.matiere);
            //Calcul la moyenne de chaque matière
            var moyennesMatieres = matiereGroupes.Select(g => g.Average(s => s.note));
            //Méthode Any parcours la collection et s'il existe au moins une valeur, renvoies la valeur moyenne
            //sinon, renvoies 0
            return moyennesMatieres.Any() ? Truncate.Truncate2decimale(moyennesMatieres.Average()) : 0;
        }

        //Méthode (overload) Moyenne pour une seule matière d'un élève
        public double Moyenne(int m)    
        {
            //Méthode Where extrait les notes qui satisfait la condition lambda
            var notesMatiere = notes.Where(n => n.matiere == m).Select(n => n.note);
            return notesMatiere.Any() ? Truncate.Truncate2decimale(notesMatiere.Average()) : 0;
        }
    }
}   

