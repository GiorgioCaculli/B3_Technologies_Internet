using System.Data.SqlClient;
using Infrastructure.SqlServer.Utils;
using NotImplementedException = System.NotImplementedException;

namespace Infrastructure.SqlServer.Repositories.Parcours
{
    public class ParcoursFactory: IDomainFactory<Domain.Parcours>
    {
        public Domain.Parcours CreateFromSqlReader(SqlDataReader reader)
        {
            return new Domain.Parcours
            {
                Identifiant = reader.GetInt32(reader.GetOrdinal(ParcoursRepository.ColIdentifiant)),
                Nom = reader.GetString(reader.GetOrdinal(ParcoursRepository.ColNom)),
                TempsMarcheMinutes = reader.GetInt32(reader.GetOrdinal(ParcoursRepository.ColTempsMarcheMinutes)),
                TempsCourseMinutes = reader.GetInt32(reader.GetOrdinal(ParcoursRepository.ColTempsCourseMinutes))
            };
        }
    }
}
