using System;

namespace Application.UseCases.Parcours.Dto
{
    public class OutputDtoParcours
    {
        public int Identifiant { get; set; }
        public string Nom { get; set; }
        public int TempsMarcheMinutes { get; set; }
        public int TempsCourseMinutes { get; set; }

        protected bool Equals(OutputDtoParcours other)
        {
            return Identifiant == other.Identifiant && Nom == other.Nom && TempsMarcheMinutes == other.TempsMarcheMinutes && TempsCourseMinutes == other.TempsCourseMinutes;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((OutputDtoParcours) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Identifiant, Nom, TempsMarcheMinutes, TempsCourseMinutes);
        }
    }
}
