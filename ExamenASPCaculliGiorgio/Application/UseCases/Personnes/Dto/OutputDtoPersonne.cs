using System;

namespace Application.UseCases.Personnes.Dto
{
    public class OutputDtoPersonne
    {
        public int Identifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        protected bool Equals(OutputDtoPersonne other)
        {
            return Identifiant == other.Identifiant && Nom == other.Nom && Prenom == other.Prenom;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((OutputDtoPersonne) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Identifiant, Nom, Prenom);
        }
    }
}
