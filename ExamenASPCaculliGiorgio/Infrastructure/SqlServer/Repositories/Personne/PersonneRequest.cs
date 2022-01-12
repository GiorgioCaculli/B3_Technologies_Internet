namespace Infrastructure.SqlServer.Repositories.Personne
{
    public partial class PersonneRepository
    {
        public const string TableName = "personnes";

        public const string ColIdentifiant = "identifiant";
        public const string ColNom = "nom";
        public const string ColPrenom = "Prenom";

        public static readonly string ReqCreate = $@"
INSERT INTO {TableName}({ColNom}, {ColPrenom}) OUTPUT INSERTED.{ColIdentifiant}
ValUES(@{ColNom}, @{ColPrenom})";

        public static readonly string ReqGetAll = $@"
SELECT * FROM {TableName}";

        public static readonly string ReqGetById = $@"
SELECT * FROM {TableName} WHERE {ColIdentifiant} = @{ColIdentifiant}";
    }
}
