namespace Domain.Interfaces
{
    public interface IPlayer
    {
        string Name { get; }
        IHand Hand { get; }
    }
}
