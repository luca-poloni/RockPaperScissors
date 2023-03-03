namespace Domain.Interfaces
{
    public interface IHand
    {
        public string Name { get; }
        bool Wins(IHand other);
    }
}
