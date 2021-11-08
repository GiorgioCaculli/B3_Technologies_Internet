namespace Infrastructure.SqlServer.Repositories.History
{
    public partial class HistoryRepository
    {
        public const string TableName = "history_items";

        public const string ColId = "id",
            ColUserId = "user_id",
            ColGameId = "game_id",
            ColMinutesPlayed = "minutes_time_played";

        public static readonly string ReqCreate = $@"
            INSERT INTO {TableName}({ColUserId}, {ColGameId}, {ColMinutesPlayed})
            OUTPUT INSERTED.{ColId}
            VALUES(@{ColUserId}, @{ColGameId}, @{ColMinutesPlayed})
        ";

        public static readonly string ReqGetHistoryItemsOfUser = $@"
            SELECT * FROM {TableName} WHERE {ColUserId} = @{ColUserId}
        ";
    }
}