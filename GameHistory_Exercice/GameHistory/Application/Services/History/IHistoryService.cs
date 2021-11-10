namespace Services.Services.History
{
    public interface IHistoryService
    {
        Domain.History GetHistoryByUserId(int userId);
    }
}