using Domain.Exceptions;
using Domain.Factories;
using Domain.Implementations;
using FluentAssertions;

namespace Domain.UnitTests.Factories
{
    public sealed class HandFactoryTest
    {
        [Fact]
        public void CreateRockHand_WithValidName_ShouldAsRock()
        {
            #region Act
            var hand = HandFactory.Create("Rock");
            #endregion

            #region Assert
            hand.Should().As<RockUseCase>();
            #endregion
        }

        [Fact]
        public void CreatePaperHand_WithValidName_ShouldAsPaper()
        {
            #region Act
            var hand = HandFactory.Create("Paper");
            #endregion

            #region Assert
            hand.Should().As<PaperUseCase>();
            #endregion
        }

        [Fact]
        public void CreateScissorsHand_WithValidName_ShouldAsScissors()
        {
            #region Act
            var hand = HandFactory.Create("Scissors");
            #endregion

            #region Assert
            hand.Should().As<ScissorsUseCase>();
            #endregion
        }

        [Fact]
        public void CreateHand_WithInvalidName_ShouldThrowExactlyInvalidHandExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var hand = HandFactory.Create("Invalid Hand Name");
            };

            action.Should()
                .ThrowExactly<InvalidHandException>().WithMessage("The hand is invalid.");
        }
    }
}
