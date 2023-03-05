using Application.Aggregates;
using Application.Handles;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/v1/game")]
    public sealed class GameController : ControllerBase
    {
        [HttpPost("play")]
        public ActionResult<IPlayer> Play(PlayersAggregate players)
        {
            var gameHandle = new GameHandle(players);
            return gameHandle.Handle();
        }
    }
}