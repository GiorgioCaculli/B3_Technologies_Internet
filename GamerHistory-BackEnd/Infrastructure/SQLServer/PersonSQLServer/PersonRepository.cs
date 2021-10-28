using System.Collections.Generic;
using Domain;

namespace Infrastructure.SQLServer.PersonSQLServer
{
    public class PersonRepository
    {
        public const string PersonTableName = "person";

        public const string ColId = "id";
        public const string ColFirstName = "firstName";
        public const string ColLastName = "lastName";

        public static readonly string ReqGetAll = "";
        public static readonly string ReqGetById = "";
        public static readonly string ReqCreate = "";
        public static readonly string ReqDelete = "";
        public static readonly string ReqUpdate = "";

        private PersonFactory _personFactory = new PersonFactory();

        public List<Person> GetAll()
        {
            var persons = new List<Person>();
            return persons;
        }

        public Person GetById(int id)
        {
            return null;
        }

        public Person Create(string firstName, string lastName)
        {
            return null;
        }

        public bool Delete(int id)
        {
            return false;
        }

        public bool Update(int id, Person person)
        {
            return false;
        }
    }
}