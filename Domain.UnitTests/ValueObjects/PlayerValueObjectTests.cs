using Domain.Enums;
using Domain.ValueObjects;
using FluentAssertions;
using FluentValidation;

namespace Domain.UnitTests.ValueObjects
{
    public class PlayerValueObjectTests
    {
        private readonly HandValueObject _handMock;

        public PlayerValueObjectTests()
        {
            _handMock = new HandValueObject(HandTypeEnum.Rock);
        }

        [Fact]
        public void CreatePlayer_WithValidParameters_ShouldNotThrow()
        {
            Action action = () =>
            {
                var player = new PlayerValueObject("Luca", _handMock);
            };

            action.Should()
                .NotThrow();
        }

        [Fact]
        public void CreatePlayer_WithEmptyName_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var player = new PlayerValueObject(string.Empty, _handMock);
            };

            action.Should()
                 .ThrowExactly<ValidationException>().WithMessage("Name is empty or contains white spaces.");
        }

        [Fact]
        public void CreatePlayer_WithWhiteSpaceName_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var player = new PlayerValueObject(string.Empty.PadLeft(10, ' '), _handMock);
            };

            action.Should()
                 .ThrowExactly<ValidationException>().WithMessage("Name is empty or contains white spaces.");
        }
    }
}
