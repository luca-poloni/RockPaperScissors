using Domain.Implementations;
using FluentAssertions;

namespace Domain.UnitTests.Implementations
{
    public class RockTest
    {
        [Fact]
        public void WinsMethod_WithScissorsHand_ShouldBeTrue()
        {
            #region Arrange
            var rock = new Rock();
            var scissors = new Scissors();
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
