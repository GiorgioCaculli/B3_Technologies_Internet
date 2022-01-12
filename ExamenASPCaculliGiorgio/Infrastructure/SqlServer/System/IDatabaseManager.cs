namespace Infrastructure.SqlServer.System
{
    public interface IDatabaseManager
    {
        void CreateTables();

        void FillTables();
    }
}
