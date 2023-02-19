using Domain.Enums;
using Domain.Exceptions;
using Domain.ValueObjects;
using FluentAssertions;
using FluentValidation;

namespace Domain.UnitTests.ValueObjects
{
    public class HandValueObjectTests
    {
        [Fact]
        public void CreateHandValueObject_WithValidParameters_ShouldNotThrow()
        {
            Action action = () =>
            {
                var hand = new HandValueObject(HandEnum.Rock);
            };

            action.Should()
                .NotThrow();
        }

        [Fact]
        public void CreateHandValueObject_WithInvalidHandEnum_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var hand = new HandValueObject(default);
            };

            action.Should()
                .ThrowExactly<ValidationException>().WithMessage("Hand Enum is outside the possible range of values.");
        }

        [Fact]
        public void WinsMethodFromHandRockType_GivenOtherHandsScissorsType_ShouldReturnTrue()
        {
            #region Arrange
            var handRock = new HandValueObject(HandEnum.Rock);
            var handScissors = new HandValueObject(HandEnum.Scissors);
            #endregion

            #region Act
            var handRockWinner = handRock.Wins(handScissors);
            #endregion

            #region Assert
            handRockWinner.Should().BeTrue();
            #endregion
        }

        [Fact]
        public void GetWinnerMethodFromHandPaperType_GivenOtherHandsRockType_ShouldReturnTrue()
        {
            #region Arrange
            var handPaper = new HandValueObject(HandEnum.Paper);
            var handRock = new HandValueObject(HandEnum.Rock);
            #endregion

            #region Act
            var handPaperWinner = handPaper.Wins(handRock);
            #endregion

            #region Assert
            handPaperWinner.Should().BeTrue();
            #endregion
        }

        [Fact]
        public void GetWinnerMethodFromHandScissorsType_GivenOtherHandsPaperType_ShouldReturnTrue()
        {
            #region Arrange
            var handScissors = new HandValueObject(HandEnum.Scissors);
            var handPaper = new HandValueObject(HandEnum.Paper);
            #endregion

            #region Act
            var handScissorsWinner = handScissors.Wins(handPaper);
            #endregion

            #region Assert
            handScissorsWinner.Should().BeTrue();
            #endregion
        }

        [Fact]
        public void GetWinnerMethodFromHandScissorsType_GivenOtherSameHand_ShouldThrowExactlyEqualsHandsExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var handScissors = new HandValueObject(HandEnum.Scissors);
                var handScissorsEqual = new HandValueObject(HandEnum.Scissors);
                handScissors.Wins(handScissorsEqual);
            };

            action.Should()
                .ThrowExactly<EqualsHandsException>().WithMessage("The hands are equals.");
        }
    }
}
