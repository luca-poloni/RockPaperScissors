using Domain.Factories;
using FluentAssertions;

namespace Domain.UnitTests.Implementations
{
    public sealed class ScissorsTest
    {
        [Fact]
        public void WinsMethod_WithPaperHand_ShouldBeTrue()
        {
            #region Arrange
            var scissors = HandFactory.Create("Scissors");
            var paper = HandFactory.Create("Paper");
            #endregion

            #region Act
            var wins = scissors.Wins(paper);
            #endregion

            #region Assert
            wins.Should().BeTrue();
            #endregion
        }
    }
}