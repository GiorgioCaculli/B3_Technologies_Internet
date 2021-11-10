namespace Infrastructure.SqlServer.Repositories.VideoGame
{
    public interface IVideoGameRepository
    {
        Domain.VideoGame Create(Domain.VideoGame videoGame);
        Domain.VideoGame GetById(int id);
        
    }
}