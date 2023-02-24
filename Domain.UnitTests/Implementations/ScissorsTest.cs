using Domain.Implementations;
using FluentAssertions;

namespace Domain.UnitTests.Implementations
{
    public class ScissorsTest
    {
        [Fact]
        public void WinsMethod_WithPaperHand_ShouldBeTrue()
        {
            #region Arrange
            var scissors = new Scissors();
            var paper = new Paper();
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