using Domain.Interfaces;

namespace Domain.Implementations
{
    public sealed class RockUseCase : IHand
    {
        public string Name { get; } = "Rock";

        public bool Wins(IHand other)
        {
            return other.GetType() == typeof(ScissorsUseCase);
        }
    }
}
