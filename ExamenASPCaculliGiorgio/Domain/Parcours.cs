using System;

namespace Domain
{
    public class Parcours
    {
        public int Identifiant { get; set; }
        public string Nom { get; set; }
        public int TempsMarcheMinutes { get; set; }
        public int TempsCourseMinutes { get; set; }

        protected bool Equals(Parcours other)
        {
            return Identifiant == other.Identifiant && Nom == other.Nom;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Parcours) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Identifiant, Nom);
        }
    }
}
