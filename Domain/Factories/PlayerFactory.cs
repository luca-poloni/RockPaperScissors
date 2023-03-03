using Domain.Implementations;
using Domain.Interfaces;

namespace Domain.Factories
{
    public static class PlayerFactory
    {
        public static IPlayer Create(string name, IHand hand)
        {
            return new PlayerUseCase(name, hand);
        }
    }
}
