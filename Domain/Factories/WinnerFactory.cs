using Domain.Implementations;
using Domain.Interfaces;

namespace Domain.Factories
{
    public static class WinnerFactory
    {
        public static IWinner Create(IPlayer playerOne, IPlayer playerTwo)
        {
            return new WinnerUseCase(playerOne, playerTwo);
        }
    }
}
