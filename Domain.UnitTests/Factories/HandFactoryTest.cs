using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.Factories
{
    public sealed class HandFactoryTest
    {
        [Fact]
        public void CreateHand_WithValidName_ShouldAsHand()
        {
            #region Act
            var hand = HandFactory.Create("Rock");
            #endregion

            #region Assert
            hand.Should().As<IHand>();
            #endregion
        }

        [Fact]
        public void CreateHand_WithInvalidName_ShouldThrowExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var hand = HandFactory.Create("Invalid Hand Name");
            };

            action.Should()
                .Throw<Exception>().WithMessage("The hand is invalid.");
        }
    }
}
