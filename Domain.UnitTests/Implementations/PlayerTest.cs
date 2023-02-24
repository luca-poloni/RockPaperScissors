using Domain.Implementations;
using FluentAssertions;
using FluentValidation;

namespace Domain.UnitTests.Implementations
{
    public class PlayerTest
    {
        private readonly Rock _handRockMock;

        public PlayerTest()
        {
            _handRockMock = new Rock();
        }

        [Fact]
        public void CreatePlayer_WithValidParameters_ShouldNotThrow()
        {
            Action action = () =>
            {
                var player = new Player("Luca", _handRockMock);
            };

            action.Should()
                .NotThrow();
        }

        [Fact]
        public void CreatePlayer_WithEmptyName_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var player = new Player(string.Empty, _handRockMock);
            };

            action.Should()
                 .ThrowExactly<ValidationException>().WithMessage("Name is empty or contains white spaces." + Environment.NewLine + "Minimum Length for Name is 3 characters.");
        }

        [Fact]
        public void CreatePlayer_WithWhiteSpaceName_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var player = new Player(string.Empty.PadLeft(10, ' '), _handRockMock);
            };

            action.Should()
                 .ThrowExactly<ValidationException>().WithMessage("Name is empty or contains white spaces.");
        }

        [Fact]
        public void CreatePlayer_WithInvalidMinimumLengthName_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var player = new Player("CJ", _handRockMock);
            };

            action.Should()
                 .ThrowExactly<ValidationException>().WithMessage("Minimum Length for Name is 3 characters.");
        }

        [Fact]
        public void CreatePlayer_WithInvalidMaximumLengthName_ShouldThrowExactlyValidationExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var player = new Player(string.Empty.PadLeft(101, 'A'), _handRockMock);
            };

            action.Should()
                 .ThrowExactly<ValidationException>().WithMessage("Maximum Length for Name is 100 characters.");
        }
    }
}
