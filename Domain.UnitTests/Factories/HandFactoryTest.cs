using Domain.Exceptions;
using Domain.Factories;
using Domain.Implementations;
using FluentAssertions;

namespace Domain.UnitTests.Factories
{
    public class HandFactoryTest
    {
        [Fact]
        public void CreateRockHand_WithValidName_ShouldAsRock()
        {
            #region Act
            var hand = HandFactory.Create("Rock");
            #endregion

            #region Assert
            hand.Should().As<Rock>();
            #endregion
        }

        [Fact]
        public void CreatePaperHand_WithValidName_ShouldAsPaper()
        {
            #region Act
            var hand = HandFactory.Create("Paper");
            #endregion

            #region Assert
            hand.Should().As<Paper>();
            #endregion
        }

        [Fact]
        public void CreateScissorsHand_WithValidName_ShouldAsScissors()
        {
            #region Act
            var hand = HandFactory.Create("Scissors");
            #endregion

            #region Assert
            hand.Should().As<Scissors>();
            #endregion
        }

        [Fact]
        public void CreateHand_WithInvalidName_ShouldThrowExactlyInvalidHandExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var hand = HandFactory.Create("Invalid Name");
            };

            action.Should()
                .ThrowExactly<InvalidHandException>().WithMessage("The hand is invalid.");
        }
    }
}
