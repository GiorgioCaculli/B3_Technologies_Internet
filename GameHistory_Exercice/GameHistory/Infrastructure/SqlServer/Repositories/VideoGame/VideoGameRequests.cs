namespace Infrastructure.SqlServer.Repositories.VideoGame
{
    public partial class VideoGameRepository
    {
        public const string TableName = "games";

        public const string ColId = "id",
            ColName = "name",
            ColMinutesCompletionTime = "minutes_for_completion";

        public static readonly string ReqCreate = $@"
            INSERT INTO {TableName}({ColName}, {ColMinutesCompletionTime})
            OUTPUT INSERTED.{ColId}
            VALUES(@{ColName}, @{ColMinutesCompletionTime})";

        public static readonly string ReqGetById = $@"
            SELECT * FROM {TableName} WHERE {ColId} = @{ColId}
        ";
    }
}