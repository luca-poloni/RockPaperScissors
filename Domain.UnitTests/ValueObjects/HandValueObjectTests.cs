using Domain.Enums;
using Domain.Exceptions;
using Domain.ValueObjects;
using FluentAssertions;
using FluentValidation;

namespace Domain.UnitTests.ValueObjects
{
    public class HandValueObjectTests
    {
        private readonly HandValueObject _handRockMock;
        private readonly HandValueObject _handPaperMock;
        private readonly HandValueObject _handScissorsMock;

        public HandValueObjectTests()
        {
            _handRockMock = new HandValueObject(HandTypeEnum.Rock);
            _handPaperMock = new HandValueObject(HandTypeEnum.Paper);
            _handScissorsMock = new HandValueObject(HandTypeEnum.Scissors);
        }

        [Fact]
        public void CreateHandValueObject_WithValidParameters_ShouldNotThrow()
        {
            Action action = () =>
            {
                var hand = new HandValueObject(HandTypeEnum.Rock);
            };

            action.Should()
                .NotThrow();
        }

        [Fact]
        public void CreateHandValueObject_WithInvalidHandTypeEnum_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var hand = new HandValueObject(default);
            };

            action.Should()
                .ThrowExactly<ValidationException>().WithMessage("Hand Type Enum is outside the possible values.");
        }

        [Fact]
        public void WinsMethodFromHandRockType_GivenOtherHandsScissorsType_ShouldReturnTrue()
        {
            #region Act
            var handRockWinner = _handRockMock.Wins(_handScissorsMock);
            #endregion

            #region Assert
            handRockWinner.Should().BeTrue();
            #endregion
        }

        [Fact]
        public void WinsMethodFromHandPaperType_GivenOtherHandsRockType_ShouldReturnTrue()
        {
            #region Act
            var handPaperWinner = _handPaperMock.Wins(_handRockMock);
            #endregion

            #region Assert
            handPaperWinner.Should().BeTrue();
            #endregion
        }

        [Fact]
        public void WinsMethodFromHandScissorsType_GivenOtherHandsPaperType_ShouldReturnTrue()
        {
            #region Act
            var handScissorsWinner = _handScissorsMock.Wins(_handPaperMock);
            #endregion

            #region Assert
            handScissorsWinner.Should().BeTrue();
            #endregion
        }

        [Fact]
        public void WinsMethodFromHandScissorsType_GivenOtherSameHand_ShouldThrowExactlyEqualsHandsExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                _handScissorsMock.Wins(_handScissorsMock);
            };

            action.Should()
                .ThrowExactly<EqualsHandsException>().WithMessage("The hands are equals.");
        }
    }
}
