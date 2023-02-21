using Domain.ValueObjects;

namespace Domain.Manipulators
{
    public record WinnerManipulator
    {
        private readonly PlayerValueObject _playerOne;
        private readonly PlayerValueObject _playerTwo;

        public WinnerManipulator(PlayerValueObject playerOne, PlayerValueObject playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
        }

        public PlayerValueObject GetWinner()
        {
            return _playerOne.Hand.Wins(_playerTwo.Hand) ? _playerOne : _playerTwo;
        }
    }
}
