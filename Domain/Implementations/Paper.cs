using Domain.Interfaces;

namespace Domain.Implementations
{
    public class Paper : IHand
    {
        public bool Wins(IHand other)
        {
            return other.GetType() == typeof(Rock);
        }
    }
}
