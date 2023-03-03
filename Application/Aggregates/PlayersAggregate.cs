using System.ComponentModel.DataAnnotations;

namespace Application.Aggregates
{
    public sealed record PlayersAggregate
    {
        [Required(ErrorMessage = "PlayerOne is required.")]
        public PlayerAggregate PlayerOne { get; }

        [Required(ErrorMessage = "PlayerTwo is required.")]
        public PlayerAggregate PlayerTwo { get; }

        public PlayersAggregate(PlayerAggregate playerOne, PlayerAggregate playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }
    }
}
