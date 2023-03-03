using Domain.Implementations;
using FluentAssertions;

namespace Domain.UnitTests.Implementations
{
    public sealed class PaperTest
    {
        [Fact]
        public void WinsMethod_WithRockHand_ShouldBeTrue()
        {
            #region Arrange
            var paper = new PaperUseCase();
            var rock = new RockUseCase();
            #endregion

            #region Act
            var wins = paper.Wins(rock);
            #endregion

            #region Assert
            wins.Should().BeTrue();
            #endregion
        }
    }
}
