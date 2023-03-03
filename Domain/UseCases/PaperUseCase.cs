using Domain.Interfaces;

namespace Domain.Implementations
{
    internal sealed class PaperUseCase : IHand
    {
        public string Name { get; } = "Paper";

        public bool Wins(IHand other)
        {
            return other.GetType() == typeof(RockUseCase);
        }
    }
}
