using Domain.Interfaces;

namespace Domain.Implementations
{
    public class Scissors : IHand
    {
        public bool Wins(IHand other)
        {
            return other.GetType() == typeof(Paper);
        }
    }
}
