using System.Data.SqlClient;
using Infrastructure.SqlServer.Utils;
using NotImplementedException = System.NotImplementedException;

namespace Infrastructure.SqlServer.Repositories.User
{
    public class UserFactory : IDomainFactory<Domain.User>
    {
        public Domain.User CreateFromSqlReader(SqlDataReader reader)
        {
            return new Domain.User()
            {
                Id = reader.GetInt32(reader.GetOrdinal(UserRepository.ColId)),
                FirstName = reader.GetString(reader.GetOrdinal(UserRepository.ColFirstName)),
                LastName = reader.GetString(reader.GetOrdinal(UserRepository.ColLastName))
            };
        }
    }
}