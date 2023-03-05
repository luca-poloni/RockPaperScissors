using Application.Aggregates;
using Domain.Factories;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Handles
{
    public class GameHandle
    {
        private readonly PlayersAggregate _players;

        public GameHandle(PlayersAggregate players)
        {
            _players = players;
        }

        public ActionResult<IPlayer> Handle()
        {
            ActionResult<IPlayer> result;

            try
            {
                var playerAggregateOne = _players.PlayerOne;
                var playerAggregateTwo = _players.PlayerTwo;

                var handOne = HandFactory.Create(playerAggregateOne.HandName);
                var handTwo = HandFactory.Create(playerAggregateTwo.HandName);

                var playerOne = PlayerFactory.Create(playerAggregateOne.Name, handOne);
                var playerTwo = PlayerFactory.Create(playerAggregateTwo.Name, handTwo);
                var winner = WinnerFactory.Create(playerOne, playerTwo);

                result = new ActionResult<IPlayer>(winner.GetWinner());
            }
            catch (Exception ex)
            {
                result = new BadRequestObjectResult(ex.Message);
            }

            return result;
        }
    }
}
