using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Infrastructure.SqlServer.Utils;
using NotImplementedException = System.NotImplementedException;

namespace Infrastructure.SqlServer.Repositories.Session
{
    public partial class SessionRepository: ISessionRepository
    {
        private readonly IDomainFactory<Domain.Session> _factory = new SessionFactory();

        public Domain.Session GetById(int id)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqGetById
            };

            command.Parameters.AddWithValue("@" + ColIdentifiant, id);
            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader.Read() ? _factory.CreateFromSqlReader(reader) : null;
        }

        public List<Domain.Session> GetAll()
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqGetAll
            };

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            List<Domain.Session> sessions = new List<Domain.Session>();
            while (reader.Read())
            {
                sessions.Add(_factory.CreateFromSqlReader(reader));
            }

            return sessions;
        }

        public Domain.Session Create(Domain.Session session)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqCreate
            };

            command.Parameters.AddWithValue("@" + ColIdUtilisateur, session.IdUtilisateur);
            command.Parameters.AddWithValue("@" + ColIdParcours, session.IdParcours);
            command.Parameters.AddWithValue("@" + ColTypeSession, session.TypeSession);
            command.Parameters.AddWithValue("@" + ColTempsMinutes, session.TempsMinutes);
            session.Identifiant = (int) command.ExecuteScalar();

            return session;
        }
    }
}
