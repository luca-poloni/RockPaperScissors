using Domain.Interfaces;

namespace Domain.Implementations
{
    public sealed class ScissorsUseCase : IHand
    {
        public string Name { get; } = "Scissors";

        public bool Wins(IHand other)
        {
            return other.GetType() == typeof(PaperUseCase);
        }
    }
}
