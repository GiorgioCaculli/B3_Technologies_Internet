using System.Collections.Generic;
using Domain;

namespace Infrastructure.SQLServer.PersonSQLServer
{
    public interface IPersonRepository
    {
        List<Person> GetAll();
        Person GetById(int id);
        Person Create(string firstName, string lastName);
        bool Delete(int id);
        bool Update(int id, Person person);
    }
}