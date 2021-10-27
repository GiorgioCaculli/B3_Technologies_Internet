using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Domain;

namespace Infrastructure.SQLServer.TodoSQLServer
{
    public class TodoRepository: ITodoRepository
    {
        public const string TableName = "todo_values";
        
        public const string ColId = "id";
        public const string ColTitle = "title";
        public const string ColIsDone = "is_done";
        
        public static readonly string ReqGetAll = $"SELECT * FROM {TableName}";
        
        public static readonly string ReqGetById = $"SELECT * FROM {TableName} WHERE {ColId} = @{ColId}";
        
        public static readonly string ReqCreate = $"INSERT INTO {TableName}({ColTitle}, {ColIsDone})" +
                                                  $" OUTPUT INSERTED.{ColId}" +
                                                  $" VALUES(@{ColTitle}, 0)";
        public static readonly string ReqDelete = $"DELETE FROM {TableName} WHERE {ColId} = @{ColId}";
        public static readonly string ReqUpdate = $"UPDATE {TableName} SET {ColTitle} = @{ColTitle}, {ColIsDone} = @{ColIsDone} WHERE {ColId} = @{ColId}";
        
        
        private TodoFactory _todoFactory = new TodoFactory();

        public List<Todo> GetAll()
        {
            var todos = new List<Todo>();

            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqGetAll
            };
            
            command.Connection = connection;
            command.CommandText = ReqGetAll;

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                todos.Add(_todoFactory.CreateFromDataReader(reader));
            }

            return todos;
        }

        public Todo GetById(int id)
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

            return reader.Read() ? _todoFactory.CreateFromDataReader(reader) : null;
        }

        public Todo Create(string title)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqCreate
            };

            command.Parameters.AddWithValue("@" + ColTitle, title);
            
            return new Todo
            {
                Id = (int) command.ExecuteScalar(),
                Title = title,
                IsDone = false
            };
        }

        public bool Delete(int id)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqDelete
            };

            command.Parameters.AddWithValue("@" + ColId, id);

            return command.ExecuteNonQuery() > 0;
        }

        public bool Update(int id, Todo todo)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqUpdate
            };

            command.Parameters.AddWithValue("@" + ColTitle, todo.Title);
            command.Parameters.AddWithValue("@" + ColIsDone, todo.IsDone);
            command.Parameters.AddWithValue("@" + ColId, id);

            return command.ExecuteNonQuery() > 0;
        }

    }
}