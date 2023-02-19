using Domain.ValueObjects;

namespace Application.Models
{
    public record PlayersModel
    {
        public PlayerValueObject PlayerOne { get; }
        public PlayerValueObject PlayerTwo { get; }

        public PlayersModel(PlayerValueObject playerOne, PlayerValueObject playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }
    }
}
