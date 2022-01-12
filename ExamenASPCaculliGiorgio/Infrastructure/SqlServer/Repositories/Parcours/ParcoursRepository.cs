using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Infrastructure.SqlServer.Utils;
using NotImplementedException = System.NotImplementedException;

namespace Infrastructure.SqlServer.Repositories.Parcours
{
    public partial class ParcoursRepository: IParcoursRepository
    {
        private readonly IDomainFactory<Domain.Parcours> _factory = new ParcoursFactory();

        public Domain.Parcours GetById(int id)
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

        public List<Domain.Parcours> GetAll()
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqGetAll
            };

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            List<Domain.Parcours> parcours = new List<Domain.Parcours>();
            while (reader.Read())
            {
                parcours.Add(_factory.CreateFromSqlReader(reader));
            }

            return parcours;
        }

        public Domain.Parcours Create(Domain.Parcours parcours)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqCreate
            };

            command.Parameters.AddWithValue("@" + ColNom, parcours.Nom);
            command.Parameters.AddWithValue("@" + ColTempsMarcheMinutes, parcours.TempsMarcheMinutes);
            command.Parameters.AddWithValue("@" + ColTempsCourseMinutes, parcours.TempsCourseMinutes);
            parcours.Identifiant = (int) command.ExecuteScalar();

            return parcours;
        }
    }
}
