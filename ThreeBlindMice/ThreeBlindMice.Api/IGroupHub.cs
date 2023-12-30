namespace ThreeBlindMice.Api
{
    public interface IGroupHub
    {
        Task SendMessage(string message);
    }
}
