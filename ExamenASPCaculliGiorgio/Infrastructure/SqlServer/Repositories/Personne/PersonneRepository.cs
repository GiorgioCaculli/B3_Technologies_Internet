using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Infrastructure.SqlServer.Utils;
using NotImplementedException = System.NotImplementedException;

namespace Infrastructure.SqlServer.Repositories.Personne
{
    public partial class PersonneRepository: IPersonneRepository
    {
        private readonly IDomainFactory<Domain.Personne> _factory = new PersonneFactory();

        public Domain.Personne GetById(int id)
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

        public List<Domain.Personne> GetAll()
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqGetAll
            };

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            List<Domain.Personne> personnes = new List<Domain.Personne>();
            while (reader.Read())
            {
                personnes.Add(_factory.CreateFromSqlReader(reader));
            }

            return personnes;
        }

        public Domain.Personne Create(Domain.Personne personne)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqCreate
            };

            command.Parameters.AddWithValue("@" + ColNom, personne.Nom);
            command.Parameters.AddWithValue("@" + ColPrenom, personne.Prenom);
            personne.Identifiant = (int) command.ExecuteScalar();

            return personne;
        }
    }
}
