using Domain.Factories;
using FluentAssertions;

namespace Domain.UnitTests.Implementations
{
    public sealed class WinnerTest
    {
        [Fact]
        public void GetWinnerMethod_WithSameHands_ShouldThrowExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var rock = HandFactory.Create("Rock");
                var playerOne = PlayerFactory.Create("Luca", rock);
                var playerTwo = PlayerFactory.Create("Caio", rock);
                var winner = WinnerFactory.Create(playerOne, playerTwo);
                winner.GetWinner();
            };

            action.Should()
                 .Throw<Exception>().WithMessage("The hands are equals.");
        }
    }
}
