using Domain.Interfaces;

namespace Domain.Implementations
{
    public class Rock : IHand
    {
        public bool Wins(IHand other)
        {
            return other.GetType() == typeof(Scissors);
        }
    }
}
