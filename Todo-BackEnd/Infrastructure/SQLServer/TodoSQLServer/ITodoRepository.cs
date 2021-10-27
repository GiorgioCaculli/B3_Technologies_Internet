using System.Collections.Generic;
using Domain;

namespace Infrastructure.SQLServer.TodoSQLServer
{
    public interface ITodoRepository
    {
        List<Todo> GetAll();
        Todo GetById(int id);
        Todo Create(string title);
        bool Delete(int id);
        bool Update(int id, Todo todo);
    }
}