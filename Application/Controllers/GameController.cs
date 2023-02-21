using Application.Aggregates;
using Domain.Manipulators;
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
                var winner = new WinnerManipulator(players.PlayerOne, players.PlayerTwo);
                result = Ok(winner.GetWinner());
            }
            catch (Exception ex)
            {
                result = BadRequest(ex.Message);
            }

            return result;
        }
    }
}