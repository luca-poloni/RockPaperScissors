using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.Factories
{
    public sealed class PlayerFactoryTest
    {
        [Fact]
        public void CreatePlayer_WithValidParameters_ShouldAsPlayer()
        {
            #region Act
            var player = PlayerFactory.Create("Rock", HandFactory.Create("Rock"));
            #endregion

            #region Assert
            player.Should().As<IPlayer>();
            #endregion
        }
    }
}
