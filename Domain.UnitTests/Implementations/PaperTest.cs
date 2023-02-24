using Domain.Implementations;
using FluentAssertions;

namespace Domain.UnitTests.Implementations
{
    public class PaperTest
    {
        [Fact]
        public void WinsMethod_WithRockHand_ShouldBeTrue()
        {
            #region Arrange
            var paper = new Paper();
            var rock = new Rock();
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
