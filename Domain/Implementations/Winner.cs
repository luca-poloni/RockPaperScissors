﻿using Domain.Exceptions;
using Domain.Interfaces;

namespace Domain.Implementations
{
    public record Winner : IWinner
    {
        private readonly IPlayer _playerOne;
        private readonly IPlayer _playerTwo;

        public Winner(IPlayer playerOne, IPlayer playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
        }

        public IPlayer GetWinner()
        {
            if (_playerOne.Hand.Equals(_playerTwo.Hand))
                throw new EqualsHandsException();

            return _playerOne.Hand.Wins(_playerTwo.Hand) ? _playerOne : _playerTwo;
        }
    }
}
