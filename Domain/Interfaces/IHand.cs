namespace Domain.Interfaces
{
    public interface IHand
    {
        string Name { get; }
        bool Wins(IHand other);
    }
}
