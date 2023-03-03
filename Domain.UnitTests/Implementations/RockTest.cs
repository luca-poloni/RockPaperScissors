using Domain.Factories;
using FluentAssertions;

namespace Domain.UnitTests.Implementations
{
    public sealed class RockTest
    {
        [Fact]
        public void WinsMethod_WithScissorsHand_ShouldBeTrue()
        {
            #region Arrange
            var rock = HandFactory.Create("Rock");
            var scissors = HandFactory.Create("Scissors");
            #endregion

            #region Act
            var wins = rock.Wins(scissors);
            #endregion

            #region Assert
            wins.Should().BeTrue();
            #endregion
        }
    }
}
