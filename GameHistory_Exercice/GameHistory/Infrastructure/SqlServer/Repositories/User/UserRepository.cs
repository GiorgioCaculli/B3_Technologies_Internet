using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Infrastructure.SqlServer.Utils;
using NotImplementedException = System.NotImplementedException;

namespace Infrastructure.SqlServer.Repositories.User
{
    public partial class UserRepository : IUserRepository
    {
        private UserFactory _userFactory = new UserFactory();
        
        public List<Domain.User> GetAll()
        {
            var users = new List<Domain.User>();
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqGetAll
            };

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                users.Add(_userFactory.CreateFromSqlReader(reader));
            }

            return users;
        }

        public Domain.User Create(Domain.User user)
        {
            using var connection = Database.GetConnection();
            
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqCreate
            };

            command.Parameters.AddWithValue("@" + ColFirstName, user.FirstName);
            command.Parameters.AddWithValue("@" + ColLastName, user.LastName);

            return new Domain.User()
            {
                Id = (int) command.ExecuteScalar(),
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }

        public Domain.User GetById(int id)
        {
            using var connection = Database.GetConnection();
            
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqGetById
            };

            command.Parameters.AddWithValue("@" + ColId, id);

            var reader = command.ExecuteReader();

            return reader.Read() ? _userFactory.CreateFromSqlReader(reader) : null;
        }
    }
}