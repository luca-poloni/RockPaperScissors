using Domain.Exceptions;
using Domain.Implementations;
using FluentAssertions;

namespace Domain.UnitTests.Implementations
{
    public class WinnerTest
    {
        [Fact]
        public void GetWinnerMethod_WithSameHands_ShouldThrowExactlyEqualsHandsExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var rock = new Rock();
                var playerOne = new Player("Luca", rock);
                var playerTwo = new Player("Caio", rock);
                var winner = new Winner(playerOne, playerTwo);
                winner.GetWinner();
            };

            action.Should()
                 .ThrowExactly<EqualsHandsException>().WithMessage("The hands are equals.");
        }
    }
}
