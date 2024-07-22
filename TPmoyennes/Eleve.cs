namespace MHN_TPmoyennes        //MHN = Minh Hoang NGUYEN
{
    public class Eleve
    {
        public string prenom { get; private set; }   //Déclration des variables
        public string nom {  get; private set; }
        public List<Note> notes { get; private set; }
        public Eleve(string Prenom, string Nom)     //Initialization des variables
        {
            prenom = Prenom;
            nom = Nom;
            notes = new List<Note>();
        }
        public void ajouterNote(Note note)          //Méthode ajouterNote avec 1 paramètre note
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
        public double Moyenne()         //Méthode Moyenne pour toutes les matières d'un élève
        {
            return notes.Any() ? Truncate.Truncate2decimale(notes.Average(s => s.note)) : 0;
            //Méthode Any parcours la liste notes et s'il existe au moins une valeur, renvoies la valeur moyenne
            //sinon, renvoies 0
        }
        public double Moyenne(int m)    //Méthode (overload) Moyenne pour une seule matière d'un élève
        {
            var notesMatiere = notes.Where(n => n.matiere == m).Select(n => n.note);
            //Méthode Where extrait les notes qui satisfait la condition lambda
            return notesMatiere.Any() ? Truncate.Truncate2decimale(notesMatiere.Average()) : 0;
        }
    }
}   

