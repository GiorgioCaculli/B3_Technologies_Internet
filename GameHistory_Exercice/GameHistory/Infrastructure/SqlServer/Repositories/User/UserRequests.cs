namespace Infrastructure.SqlServer.Repositories.User
{
    public partial class UserRepository
    {
        public const string TableName = "users";

        public const string ColId = "id", ColFirstName = "first_name", ColLastName = "last_name";

        public static readonly string ReqGetAll = $"SELECT * FROM {TableName}";
        
        public static readonly string ReqGetById = $"SELECT * FROM {TableName} WHERE {ColId} = @{ColId}";
        
        public static readonly string ReqCreate = $"INSERT INTO {TableName} ({ColFirstName},{ColLastName}) " +
                                                  $"OUTPUT INSERTED.{ColId} " +
                                                  $"VALUES (@{ColFirstName}, @{ColLastName})";

        public static readonly string ReqDelete = $"DELETE FROM {TableName} WHERE {ColId} = @{ColId}";

        public static readonly string ReqUpdate = $"UPDATE {TableName} " +
                                                  $"SET {ColFirstName} = @{ColFirstName}, " +
                                                  $"{ColLastName} = @{ColLastName} " +
                                                  $"WHERE {ColId} = @{ColId}";
    }
}