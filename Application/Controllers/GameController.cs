using Application.Aggregates;
using Domain.Factories;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/v1/game")]
    public sealed class GameController : ControllerBase
    {
        [HttpPost("play")]
        public IActionResult Play(PlayersAggregate players)
        {
            IActionResult result;

            try
            {
                var playerAggregateOne = players.PlayerOne;
                var playerAggregateTwo = players.PlayerTwo;

                var handOne = HandFactory.Create(playerAggregateOne.HandName);
                var handTwo = HandFactory.Create(playerAggregateTwo.HandName);

                var playerOne = PlayerFactory.Create(playerAggregateOne.Name, handOne);
                var playerTwo = PlayerFactory.Create(playerAggregateTwo.Name, handTwo);
                var winner = WinnerFactory.Create(playerOne, playerTwo);

                result = Ok(winner.GetWinner().ToString());
            }
            catch (Exception ex)
            {
                result = BadRequest(ex.Message);
            }

            return result;
        }
    }
}