using System;

namespace Domain
{
    public class Personne
    {
        public int Identifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        protected bool Equals(Personne other)
        {
            return Identifiant == other.Identifiant && Nom == other.Nom && Prenom == other.Prenom;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Personne) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Identifiant, Nom, Prenom);
        }
    }
}
