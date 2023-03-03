using Domain.Implementations;
using FluentAssertions;

namespace Domain.UnitTests.Implementations
{
    public sealed class ScissorsTest
    {
        [Fact]
        public void WinsMethod_WithPaperHand_ShouldBeTrue()
        {
            #region Arrange
            var scissors = new ScissorsUseCase();
            var paper = new PaperUseCase();
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