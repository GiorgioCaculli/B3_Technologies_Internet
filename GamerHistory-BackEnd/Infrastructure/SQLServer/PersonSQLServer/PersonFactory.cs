using System.Data.SqlClient;
using Domain;

namespace Infrastructure.SQLServer.PersonSQLServer
{
    public class PersonFactory
    {
        public Person CreateFromDataReader(SqlDataReader reader)
        {
            var person = new Person
            {
                Id = reader.GetInt32(reader.GetOrdinal(PersonRepository.ColId)),
                FirstName = reader.GetString(reader.GetOrdinal(PersonRepository.ColFirstName)),
                LastName = reader.GetString(reader.GetOrdinal(PersonRepository.ColLastName))
            };
            return person;
        }
    }
}