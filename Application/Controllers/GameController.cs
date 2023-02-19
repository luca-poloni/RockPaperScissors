using Application.Models;
using Domain.Aggregates;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/v1/game")]
    public class GameController : ControllerBase
    {
        [HttpPost("play")]
        public IActionResult Play(PlayersModel players)
        {
            IActionResult result;

            try
            {
                var winner = new WinnerAggregate(players.PlayerOne, players.PlayerTwo);
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