using Domain.Exceptions;
using Domain.Implementations;
using FluentAssertions;

namespace Domain.UnitTests.Implementations
{
    public sealed class WinnerTest
    {
        [Fact]
        public void GetWinnerMethod_WithSameHands_ShouldThrowExactlyEqualsHandsExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var rock = new RockUseCase();
                var playerOne = new PlayerUseCase("Luca", rock);
                var playerTwo = new PlayerUseCase("Caio", rock);
                var winner = new WinnerUseCase(playerOne, playerTwo);
                winner.GetWinner();
            };

            action.Should()
                 .ThrowExactly<EqualsHandsException>().WithMessage("The hands are equals.");
        }
    }
}
