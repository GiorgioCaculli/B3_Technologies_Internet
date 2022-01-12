using System.Data.SqlClient;
using Infrastructure.SqlServer.Utils;
using NotImplementedException = System.NotImplementedException;

namespace Infrastructure.SqlServer.Repositories.Personne
{
    public class PersonneFactory: IDomainFactory<Domain.Personne>
    {
        public Domain.Personne CreateFromSqlReader(SqlDataReader reader)
        {
            return new Domain.Personne
            {
                Identifiant = reader.GetInt32(reader.GetOrdinal(PersonneRepository.ColIdentifiant)),
                Nom = reader.GetString(reader.GetOrdinal(PersonneRepository.ColNom)),
                Prenom = reader.GetString(reader.GetOrdinal(PersonneRepository.ColPrenom))
            };
        }
    }
}
