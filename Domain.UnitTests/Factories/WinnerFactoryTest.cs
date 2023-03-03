using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.Factories
{
    public class WinnerFactoryTest
    {
        [Fact]
        public void CreateWinner_WithValidParameters_ShouldAsWinner()
        {
            #region Act
            var playerOne = PlayerFactory.Create("Luca", HandFactory.Create("Rock"));
            var playerTwo = PlayerFactory.Create("Jhon", HandFactory.Create("Paper"));
            var winner = WinnerFactory.Create(playerOne, playerTwo);
            #endregion

            #region Assert
            winner.Should().As<IWinner>();
            #endregion
        }
    }
}
