using System;

namespace Application.UseCases.Sessions.Dto
{
    public class OutputDtoSession
    {
        public int Identifiant { get; set; }
        public int IdUtilisateur { get; set; }
        public int IdParcours { get; set; }
        public string TypeSession { get; set; }
        public int TempsMinutes { get; set; }

        protected bool Equals(OutputDtoSession other)
        {
            return Identifiant == other.Identifiant && IdUtilisateur == other.IdUtilisateur && IdParcours == other.IdParcours && TypeSession == other.TypeSession && TempsMinutes == other.TempsMinutes;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((OutputDtoSession) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Identifiant, IdUtilisateur, IdParcours, TypeSession, TempsMinutes);
        }
    }
}
