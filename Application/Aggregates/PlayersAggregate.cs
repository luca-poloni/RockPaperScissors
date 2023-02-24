using System.ComponentModel.DataAnnotations;

namespace Application.Aggregates
{
    public record PlayersAggregate
    {
        [Required]
        public PlayerAggregate PlayerOne { get; }

        [Required]
        public PlayerAggregate PlayerTwo { get; }

        public PlayersAggregate(PlayerAggregate playerOne, PlayerAggregate playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }
    }
}
