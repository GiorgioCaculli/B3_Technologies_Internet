namespace Infrastructure.SqlServer.Repositories.Session
{
    public partial class SessionRepository
    {
        public const string TableName = "sessions";

        public const string ColIdentifiant = "identifiant";
        public const string ColIdUtilisateur = "id_utilisateur";
        public const string ColIdParcours = "id_parcours";
        public const string ColTypeSession = "type_session";
        public const string ColTempsMinutes = "temps_minutes";

        public static readonly string ReqCreate = $@"
INSERT INTO {TableName}({ColIdUtilisateur}, {ColIdParcours}, {ColTypeSession}, {ColTempsMinutes}) OUTPUT INSERTED.{ColIdentifiant}
VALUES(@{ColIdUtilisateur}, @{ColIdParcours}, @{ColTypeSession}, @{ColTempsMinutes})";

        public static readonly string ReqGetAll = $@"
SELECT * FROM {TableName}";

        public static readonly string ReqGetById = $@"
SELECT * FROM {TableName} WHERE {ColIdentifiant} = @{ColIdentifiant}";
    }
}
