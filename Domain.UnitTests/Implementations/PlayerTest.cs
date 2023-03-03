using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;
using FluentValidation;

namespace Domain.UnitTests.Implementations
{
    public sealed class PlayerTest
    {
        private readonly IHand _handRockMock;

        public PlayerTest()
        {
            _handRockMock = HandFactory.Create("Rock");
        }

        [Fact]
        public void CreatePlayer_WithValidParameters_ShouldNotThrow()
        {
            Action action = () =>
            {
                var player = PlayerFactory.Create("Luca", _handRockMock);
            };

            action.Should()
                .NotThrow();
        }

        [Fact]
        public void CreatePlayer_WithEmptyName_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var player =  PlayerFactory.Create(string.Empty, _handRockMock);
            };

            action.Should()
                 .ThrowExactly<ValidationException>().WithMessage("Name is empty or contains white spaces." + Environment.NewLine + "Minimum Length for Name is 3 characters.");
        }

        [Fact]
        public void CreatePlayer_WithWhiteSpaceName_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var player =  PlayerFactory.Create(string.Empty.PadLeft(10, ' '), _handRockMock);
            };

            action.Should()
                 .ThrowExactly<ValidationException>().WithMessage("Name is empty or contains white spaces.");
        }

        [Fact]
        public void CreatePlayer_WithInvalidMinimumLengthName_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var player =  PlayerFactory.Create("CJ", _handRockMock);
            };

            action.Should()
                 .ThrowExactly<ValidationException>().WithMessage("Minimum Length for Name is 3 characters.");
        }

        [Fact]
        public void CreatePlayer_WithInvalidMaximumLengthName_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var player =  PlayerFactory.Create(string.Empty.PadLeft(101, 'A'), _handRockMock);
            };

            action.Should()
                 .ThrowExactly<ValidationException>().WithMessage("Maximum Length for Name is 100 characters.");
        }
    }
}
