using Application.ValueObjects;

namespace Application.Aggregates
{
    public sealed record PlayersAggregate
    {
        public PlayerVO PlayerOne { get; }
        public PlayerVO PlayerTwo { get; }

        public PlayersAggregate(PlayerVO playerOne, PlayerVO playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }
    }
}
