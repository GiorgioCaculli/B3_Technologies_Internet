using System.Data.SqlClient;
using Infrastructure.SqlServer.Utils;
using NotImplementedException = System.NotImplementedException;

namespace Infrastructure.SqlServer.Repositories.Session
{
    public class SessionFactory: IDomainFactory<Domain.Session>
    {
        public Domain.Session CreateFromSqlReader(SqlDataReader reader)
        {
            return new Domain.Session
            {
                Identifiant = reader.GetInt32(reader.GetOrdinal(SessionRepository.ColIdentifiant)),
                IdUtilisateur = reader.GetInt32(reader.GetOrdinal(SessionRepository.ColIdUtilisateur)),
                IdParcours = reader.GetInt32(reader.GetOrdinal(SessionRepository.ColIdParcours)),
                TypeSession = reader.GetString(reader.GetOrdinal(SessionRepository.ColTypeSession)),
                TempsMinutes = reader.GetInt32(reader.GetOrdinal(SessionRepository.ColTempsMinutes))
            };
        }
    }
}
