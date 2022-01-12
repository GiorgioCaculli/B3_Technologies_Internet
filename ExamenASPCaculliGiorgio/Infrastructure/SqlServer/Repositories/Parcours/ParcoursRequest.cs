namespace Infrastructure.SqlServer.Repositories.Parcours
{
    public partial class ParcoursRepository
    {
        public const string TableName = "parcours";

        public const string ColIdentifiant = "identifiant";
        public const string ColNom = "nom";
        public const string ColTempsMarcheMinutes = "temps_marche_minutes";
        public const string ColTempsCourseMinutes = "temps_course_minutes";

        public static readonly string ReqCreate = $@"
INSERT INTO {TableName}({ColNom}, {ColTempsMarcheMinutes}, {ColTempsCourseMinutes}) OUTPUT INSERTED.{ColIdentifiant}
VALUES(@{ColNom}, @{ColTempsMarcheMinutes}, @{ColTempsCourseMinutes})";

        public static readonly string ReqGetAll = $@"
SELECT * FROM {TableName}";

        public static readonly string ReqGetById = $@"
SELECT * FROM {TableName} WHERE {ColIdentifiant} = @{ColIdentifiant}";
    }
}
