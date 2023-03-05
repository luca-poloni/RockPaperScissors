namespace Application.Models
{
    public sealed record PlayersModel
    {
        public PlayerModel PlayerOne { get; }
        public PlayerModel PlayerTwo { get; }

        public PlayersModel(PlayerModel playerOne, PlayerModel playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }
    }
}
