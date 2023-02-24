using Application.Aggregates;
using Domain.Factories;
using Domain.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/v1/game")]
    public class GameController : ControllerBase
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

                var playerOne = new Player(playerAggregateOne.Name, handOne);
                var playerTwo = new Player(playerAggregateTwo.Name, handTwo);
                var winner = new Winner(playerOne, playerTwo);

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