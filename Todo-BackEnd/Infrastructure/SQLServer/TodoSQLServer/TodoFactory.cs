using System.Data.SqlClient;
using Domain;

namespace Infrastructure.SQLServer.TodoSQLServer
{
    public class TodoFactory
    {
        public Todo CreateFromDataReader(SqlDataReader reader)
        {
                var todo = new Todo
                {
                    Id = reader.GetInt32(reader.GetOrdinal(TodoRepository.ColId)),
                    Title = reader.GetString(reader.GetOrdinal(TodoRepository.ColTitle)),
                    IsDone = reader.GetBoolean(reader.GetOrdinal(TodoRepository.ColIsDone))
                };
                return todo;
        }
    }
}