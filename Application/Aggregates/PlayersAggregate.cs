using Domain.ValueObjects;

namespace Application.Aggregates
{
    public record PlayersAggregate
    {
        public PlayerValueObject PlayerOne { get; }
        public PlayerValueObject PlayerTwo { get; }

        public PlayersAggregate(PlayerValueObject playerOne, PlayerValueObject playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }
    }
}
