using Domain.Interfaces;

namespace Domain.Implementations
{
    public sealed class PaperUseCase : IHand
    {
        public string Name { get; } = "Paper";

        public bool Wins(IHand other)
        {
            return other.GetType() == typeof(RockUseCase);
        }
    }
}
